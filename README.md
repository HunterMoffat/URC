Author:   Hunter Moffat<br/>

Partner:   NONE<br/>

Date:      10/30/2020<br/>

Course:    CS 4540, University of Utah, School of Computing<br/>

Copyright: CS 4540 and Hunter Moffat - This work may not be copied for use in Academic Coursework.<br/>


Deployed URL:  ec2-3-234-218-100.compute-1.amazonaws.com<br/>

Github Page:   https://github.com/HunterMoffat/WebApplication1.git (ASSIGNMENT 6 BRANCH)
Comments to Evaluators:<br/>

I talked to the TAs and got permission to submit this late, if you are grading this and saw my message on piazza, thank you for understanding my situation and giving me some breathing room to complete this assignment.  I hope it is not "too late". Unfortunately, I was unable to get postman working correctly, I checked Piazza for help on this but I could not find anything, it may have to do with how my "find" button works.  On top of that, I named my model "Application" instead of "Student" this was because I got very confused because we were supposed to create student applications but the assignment said students, it just made more sense in my mind to name it applications.  Also when you test the application link for each student under the TA drop down make sure you log into the student account first before trying to view the application.  This has to do with how I implemented the project. <br/>

Assignment Specific Write-up:<br/>

Data Validation:<br/>
1. I validate the Application's UID so that it is in the correct format.
2. I validate the Application's GPA so that it is in between 0 and 4
3. I validate the Application's statement is not longer than 500 characters
4-5. I validate that the Application's DateCreated and TimeModified variables are automatically generated when the application is created or modified.
6. I validate that the Application's version number is not scaffolded.

From my understanding, Validation information means that before an entry is added to the database the front end checks each field containing a validation tag before submitting the entry to the back end to be added.  If one of the validation tags is violated, the front end will require the user to fix the fields before sending the entry to the back end to be added to the database. These tags can also tell the back end to auto generate feilds of that are not required from the front end and tell asp not to scaffold certain fields.  
<br/>
Above and Beyond:<br/>
So I did not do anything crazy that is beyond the assignment specs, I added a toggle switch for the user to change if they are actively searching for an opportunity or not because I thought it was clearer than adding a button.
<br/>
Improvements:<br/>
I added a cool bootstrap table using jquery that makes the tables a lot nicer to look at.
<br/>Feedback:<br/>
This assignment was fun, although I am turning it in a little late I feel bad because I did not really get a solid grasp on postman from the lectures and I wish I attended office hours to set it up properly, but that is on me.  I still feel a little unsure about AJAX and Java Script it took me way longer than I would like to admit to implement the search functionality and I could not for the life of me figure out how to get it working in postman making me think I did the find button incorrectly, but it works as the assignment intended. <br/>
Peers Helped:
<br/>
No one
<br/>
Peers Consulted:<br/>
 
No one<br/>

Acknowledgements:<br/>
I used some code for tables which are all credited in my css files.  <br/>

   
References:<br/>

   1. Assignment page<br/>
   2. lecture videos<br/>
   3. https://www.tutorialspoint.com/ (For basic Ajax information) <br/>
   4. https://www.w3schools.com/ (For basic Ajax information) <br/>
  
