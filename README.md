# Team-Builder-2

Assignment Brief : Team Builder Revisited 
Your client TeamBuilder Ltd wishes to update the application developed previously by adding new 
functionality, and refactoring some of its existing functionality.  
Due to recent successful trading, the company has decided to increase its event offerings from 5 to ten, 
while retaining the same five locations as before (see appendix for event and location offerings). With 
such an increased array of events at each location and after use of their current system by the sales 
team for a period of time, management have realized the limitations of their existing system in that: 
a) they need to provide faster pricing information to their sales team. 
b) clients should be able to book multiple places at an event, and also to book multiple events in 
the same sales order. 
c) they need to keep a live count of places available for each of its offerings to ensure they do not 
over sell places. 

Basic Flow of Events 
Each client sales order is compiled by the front of house sales team one event at a time. The client 
chooses an event and location, when the staff member enters these details into the app the price for the 
selections made is automatically displayed on the interface. If the client wishes to choose a meal 
option, this is inputted, and the total event price will again update automatically. The prices charged 
for each meal plan are as before. (see pricing for events/locations and event/meals in Appendix). After 
feedback from clients, every participant now receives a printed certificate free of charge. 
 
Next the staff member enters the quantity of places for the chosen event that the client wishes to book 
and presses the ‘Add to Booking’ button. If there are enough places left for the event in the chosen 
location, the event details are displayed in an appropriate control, while a running total for the sales 
order is also displayed. If there is insufficient places to fulfil the clients request, the salesperson is 
informed how many places are left in a message box control; when the server presses the OK button, 
the cursor returns to the quantity text box with the number of available places pre-entered for 
processing or writing over.  
If the customer wishes to add another event to their sales order, the process as above is repeated. 
[Note: If at any point the customer wishes to cancel their order or change their order, the clear button 
is pressed, and the form is reset so the order can be re-entered, or another customer order taken] 
Once the clients sales order has been taken in full, the employee presses the complete order button, 
after which an order summary in the form of a formatted message box (or other form as desired) is 
displayed with a transaction number, the quantity, event, location, meal plans and price for each event 
booked, along with a total cost of the sales order. 

Additional Required Functionality 
• When the exit button is pressed at the end of the day’s trading, all the orders from that day are 
to be saved to text file for financial purposes. Each trading day has its own unique transaction 
text file. The closing stock of event places is also written out to file, so this data can be used as 
the opening stock for the following days trading.  
• When/ as requested a suitability formatted management report of available event places should 
be saved to file. 
Note: Summary, Search and Log in functionality are not to be provided in this revised application 
Design Notes 
• Follow principles of good Ux design. 
• Handle any exceptions that could occur in your project & provide user input validation as 
needed. 
• Include appropriate ToolTips & Access keys. 
