Simple application for viewing referenced images (forms). Based off the workflow used in a medical laboratory.

Desktop application connects to a SQL server database (backup included in the repo) and searches for records matching an ID. 

Records are grouped by date of scan, so multiple forms with the same ID scanned on the same day will be grouped. 

**Desktop Settings** (Accessed via the Settings button)

Server - address of the SQL server

Database - name of the SQL database on that server

Use Default Credentials - whether to use Integrated Security or the provided credentials

Username - overridden username

Password - overridden password

File Server - path to the root of where images are held


**SQL Setup**

Database contains two tables (tblFormInstance and tblFormReference), one view (vwLinkedFormReferences), and one stored procedure (spGetFormsByReferenceNumber)


_tblFormInstance_

Holds unique references to a form.

ID - Autogenerated, unique ID for the image

Type - The type of form, Image or Pdf (Pdf not currently supported)

Path - The path to the file, relative to the File Server path above

Timestamp - When the image was scanned / uploaded (for grouping - see above)


_tblFormReference_

Holds the mappings between reference ID and form file.  Used to allow multiple references to a single file (such as multiple accession numbers on one form).

FormID - the ID of the form from the tblFormInstance table

ReferenceNumber - the human readable reference number, such as an accession number


_vwLinkedFormReferences_

Combines the two tables into one view


_spGetFormsByReferenceNumber_

Stored procedure (used by the FormView libraries) to get all form images based on a reference number.

Input - Reference number - the human readable reference number
