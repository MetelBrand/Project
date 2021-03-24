## Table of Contents
* [Requirements](#Requirements)





##### Requirements List
Req ID | Requirement | Test Method | Test ID
--- | --- | --- | ---
1.1 | The system shall display all the required fields to create an account.| Inspection | 1		
1.1.2	| The system shall send an email to the user to confirm that the email is valid. |	Inspection, Test	| 1
1.2	| The system shall display confirmation of the account created. | Inspection | 1
2.0 | The system shall allow the user to login.  | Test | 2
2.1	| The system shall allow the user to input their username and password. | Test	| 2
2.1.1	| The system shall verify the username and password	| Analysis	| 2
2.2	| The system shall allow the user to recover a forgotten username or password.Test	3
2.2.1	| The system shall send an email displaying the user’s username. | Inspection |	3
2.2.2	| The system shall send an email with a link to reset the user’s password. | Inspection, Test	| 3
3.0 | The system shall allow the user to post items. | Test	| 4
3.1	| The system shall allow the user to upload a picture for the item	| Test, Inspection	| 4
3.2	| The system shall allow the user to take a picture for the item.	| Test, Inspection	| 4
3.3	| The system shall allow the user to assign a location for the item. | Test, Inspection	| 4
3.3.1	| The system shall allow the user to create a new location. | Test, Inspection	| 4
3.4	| The system shall allow the user to assign a category for the item. | Test, Inspection	| 4
3.4.1	| The system shall allow the user to create a new category for the item.	| Test, Inspection	| 4
3.5	| The system shall allow the user to assign a quantity for the item.	| Test	| 4
4.0 | The system shall allow The System shall correctly the identify the user's location within 0.5 mile.	| Analysis	| 5
4.1	| The System shall provide capability to use the user's location provided by the user's browser location services. | Analysis	| 5
4.1.1	| The System shall request permission to use the user's browser location services if not already granted. | Inspection, Test	| 5
4.1.2	| Given authorization, the system shall report the client's location using the browser's location services. | Inspection	| 5
4.1.3	| The system shall display the user's location on the interface based on the reported location. | Inspection	| 5
