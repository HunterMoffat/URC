Author:   Hunter Moffat<br/>

Partner:   NONE<br/>

Date:      10/12/2020<br/>

Course:    CS 4540, University of Utah, School of Computing<br/>

Copyright: CS 4540 and Hunter Moffat - This work may not be copied for use in Academic Coursework.<br/>


Deployed URL:  ec2-35-174-136-32.compute-1.amazonaws.com<br/>

Github Page:   https://github.com/HunterMoffat/WebApplication1.git (ASSIGNMENT 4 BRANCH)
Comments to Evaluators:<br/>

I am turning in this assignment very late.  Unfortunately I was unable to get to this assignment until like Wednesday last week.  I had some very unexpected computer issues that occured Thursday night. My laptop overheated and quite literally exploded (the bottom of my laptop is now completely separated from the rest of the case) which is kinda of nuts given the laptop I have has great build quality.  Somehow I was able to get it working again, but now it runs very, very slowly making programming a total pain in the butt.  I am in the process of buying a new computer.  Also I was a little unsure about the single opportunities edit page.  I think this assignment was really fun once the due date passed I stopped rushing the assignment and really took my time with it. The link in the TA nav bar directs you to an opportunity edit page of an opportunity owned by a professor.  You have to be a professor or admin to view/edit it.<br/>

Assignment Specific Write-up:<br/>

Authorization and Authentication: <br/>
I noticed a bunch of really cool things while developing about authorization and authentication.  I found the process of "walling off" pages to be very intuitive and suprisingly easy to implement.  I also realized how awesome dependency injection is, the signinManager and UserManager are so powerful and if I had not taken so long to finish this assignment, I would have made so the admin's view of the website was completely different from the rest, sort of like a 'dark mode' which could be really cool in my opinion.  I also attempted to brake my website by trying to figure out ways that a student can view an admin only page.  I tried for maybe an hour and found some bugs, but ultimately couldn't brake my website.
<br/>
Above and Beyond:<br/>
So I did not do anything crazy that is beyond the assignment specs, but I did add role unique buttons to the Opportunities overview page and specific opportunities pages.  So when you are an admin or professor when viewing the overview page ther will be buttons to edit (if its the professor's opportunity) next to the details page.  I also added buttons that behave exactly the same way on each opportunities details page.  For students viewing the overview or detail pages, I added an "apply" button which is not visible to the other roles.  The apply button directs the student to the application forms page from assignment 2.
<br/>
Improvements:<br/>
I cleaned up my nav bar so it no longer looks like a 3 year old did it.  The login button is always going to be on the right side of the page. I don't think I made any other improvements.
<br/>Feedback:<br/>
 One thing I wish was covered more in class is the set up.  I ended up rewatching the videos countless times to see if I was missing anything.  The set up took the most time for this project specifically the datatables.  I spent hours trying to figure out why the table wasn't working only to find out that I was importing jquery in the layout and once again in my role manager. This assignment took me about 12 hours + to complete, but a good 7 hours of that was setting things up properly.  <br/>
Peers Helped:
<br/>
No one
<br/>
Peers Consulted:<br/>
 
No one<br/>

Acknowledgements:<br/>
Honestly for this assignment, I didn't really use anything I found on the internet, I did have a really messy site.js file with a bunch of code to test datatables and ajax.  Turns out all the code I copied from stack overflow was useless and all I really had to do was use the $.post() function.  One thing I did copy and barely change was the EmailSender from that microsoft tutorial, but I think thats what was expected.  The most useful thing for me was using the auto generated code from the last assignment as a reference.   <br/>

   
References:<br/>

   1. Assignment page<br/>
   2. lecture videos<br/>
   3. https://www.tutorialspoint.com/ (For basic Ajax information) <br/>
   4. https://www.w3schools.com/ (For basic Ajax information) <br/>
  
