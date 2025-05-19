using FormView_Desktop.Controls;
using FormViewLibraries;
using FormViewLibraries.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormView_Desktop.Forms
{
    public partial class Main : System.Windows.Forms.Form
    {
        private List<FormViewLibraries.Forms.FormCollection>
            _searchResults;

        private FormViewLibraries.Forms.FormCollection
            _currentForms;

        private FormViewLibraries.Forms.Form
            _currentForm;

        public Main()
        {
            InitializeComponent();
        }

        private void textBox_formNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            var searchValue = textBox_formNumber.Text.Trim();

            if (string.IsNullOrEmpty(searchValue))
            {
                return;
            }

            var manager = new FormViewManager()
            {
                ConnectionString = @"Server=(LocalDB)\MSSQLLocalDB;Database=FormView;Trusted_Connection=True;" //TODO = get from settings
            };

            _searchResults = manager.GetAllFormsForID(searchValue);

            RefreshSearchResults();
        }

        private void RefreshSearchResults()
        {
            panel_results.Controls.Clear();

            RadioButton firstItem = null;
            foreach (var item in _searchResults)
            {
                var radioButton = new RadioButton();
                radioButton.Tag = item;
                radioButton.Dock = DockStyle.Top;
                radioButton.FlatStyle = FlatStyle.Standard;
                radioButton.Appearance = Appearance.Button;
                radioButton.Text = item.Timestamp.ToString(); // TODO - set this name based on grouping
                radioButton.TextAlign = ContentAlignment.MiddleCenter;
                radioButton.CheckedChanged += OnFormCollectionCheckChanged;
                panel_results.Controls.Add(radioButton);
                radioButton.BringToFront();

                if (firstItem == null)
                {
                    firstItem = radioButton;
                }
            }

            if (firstItem != null)
            {
                firstItem.Checked = true;
            }
            else
            {
                //Clear view / show no items
                panel_currentForm.Controls.Clear();
            }
        }

        private void OnFormCollectionCheckChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;

            if (!radioButton.Checked)
            {
                return;
            }

            _currentForms = radioButton.Tag as FormViewLibraries.Forms.FormCollection;

            if (_currentForms == null)
            {
                panel_pages.Visible = false;
                return;
            }
            else
            {
                panel_pages.Visible = true;
            }

            numericUpDown_currentPage.Maximum = _currentForms.FormList.Count;
            label_viewTotal.Text = _currentForms.FormList.Count.ToString();
            button_viewAll.Enabled = numericUpDown_currentPage.Maximum > 1;
            numericUpDown_currentPage.Value = numericUpDown_currentPage.Minimum;    //TODO - select this from settings - might want to select all (0) or last etc.
            RefreshFormList();
        }

        private void RefreshFormList()
        {
            RefreshForm();

            button_viewFirst.Enabled = numericUpDown_currentPage.Value > 1;
            button_viewPrevious.Enabled = numericUpDown_currentPage.Value > 1;

            button_viewLast.Enabled = numericUpDown_currentPage.Value < numericUpDown_currentPage.Maximum;
            button_viewNext.Enabled = numericUpDown_currentPage.Value < numericUpDown_currentPage.Maximum;

            if (_currentForms.FormList.Count > 1)
            {
                numericUpDown_currentPage.Minimum = 0;
            }
            else
            {
                numericUpDown_currentPage.Minimum = 1;
            }
        }

        private void panel_viewSpecific_SizeChanged(object sender, EventArgs e)
        {
            var control = sender as Control;
            control.Left = (control.Parent.Width - control.Width) / 2;
        }

        private void numericUpDown_currentPage_ValueChanged(object sender, EventArgs e)
        {
            RefreshFormList();
        }

        private void button_viewFirst_Click(object sender, EventArgs e)
        {
            numericUpDown_currentPage.Value = 1;
        }

        private void button_viewPrevious_Click(object sender, EventArgs e)
        {
            numericUpDown_currentPage.Value = numericUpDown_currentPage.Value - 1;
        }

        private void button_viewNext_Click(object sender, EventArgs e)
        {
            numericUpDown_currentPage.Value = numericUpDown_currentPage.Value + 1;
        }

        private void button_viewLast_Click(object sender, EventArgs e)
        {
            numericUpDown_currentPage.Value = numericUpDown_currentPage.Maximum;
        }

        private void RefreshForm()
        {
            panel_currentForm.Controls.Clear();

            if (numericUpDown_currentPage.Value == 0)
            {
                _currentForm = null;
            }
            else
            {
                _currentForm = _currentForms.FormList[(int)numericUpDown_currentPage.Value - 1];
            }

            Control newControl = null;
            if (_currentForm == null)
            {
                var summary = new SummaryViewControl();
                summary.Forms = _currentForms.FormList;
                summary.FormWidth = 200;
                summary.SizeRatio = 1.4f;
                summary.OnFormClicked += Summary_OnFormClicked;
                newControl = summary;

            }
            else if (_currentForm is ImageForm imageForm)
            {
                var imageViewer = new ImageViewControl();
                imageViewer.Image = new Bitmap(imageForm.Filename); //TODO - check this gets disposed
                newControl = imageViewer;

            }
            else if (_currentForm is PdfForm pdfForm)
            {
                throw new NotImplementedException();

                var browser = new WebBrowser();
                browser.AllowNavigation = false;
                browser.AllowWebBrowserDrop = false;
                browser.WebBrowserShortcutsEnabled = false;
                browser.Navigate(pdfForm.Url);

                newControl = browser;
            }
            else
            {
                throw new NotImplementedException();
            }

            newControl.Dock = DockStyle.Fill;
            panel_currentForm.Controls.Add(newControl);
        }

        private void Summary_OnFormClicked(object sender, FormClickedArgs args)
        {
            numericUpDown_currentPage.Value = args.Index + 1;
        }

        private void button_viewAll_Click(object sender, EventArgs e)
        {
            numericUpDown_currentPage.Value = 0;
        }
    }
}
