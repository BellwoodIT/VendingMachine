# VendingMachine
Simple demo for vending machine

Software
- Visual studio
- .Net framework 4.0

Requirements
- web page interface to simulate physical payments
- system should accept cash or credit cards 
  - the following cash denomination are accepted: $5, $1, 25¢, 10¢, 5¢ 
  - credit card payments can be simulated by entering the credit card # 
- credit card payments are subject to a 5% transaction fee 
- credit card processing should be mocked out as an external service 
  - takes in the credit card # 
  - returns a success for numbers with a length of 16, otherwise returns a failure 
- current product inventory should be listed on the screen with item #, price, and name 
- system should track remaining quantity for each product, and highlight items that are sold out 
- for demo, the initial state should load 10 items with a quantity of 5 of each 
- interface should mimic a physical keypad, allowing the item # number to be entered one digit at a time, cleared one digit at a time, and the selection confirmed 
- an error message should be displayed when no matching product is found (either missing item #, or sold out) 
- selecting a product can be canceled, returning change to the customer (if any) 
- for cash payments, system must be able to make correct change for the selection before confirming purchase 
- system should display the denomination and quantity of all change returned 
- if a credit card # is entered, any cash already added should be returned in full after a purchase is made 
- for demo, the initial state should load a quantity of 5 of each supported cash denomination

