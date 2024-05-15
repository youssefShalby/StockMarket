# **Stock Market App**
## **Installation**
clone the project or download it in your machine

### **How Use App**
1. Now the files on your machine
2. Register in the App by new Account (we use simple auth system, not need to confirm account)
3. then, login by [email & password] that you are registered by them, (after 1 day you will loged out automatically)
4. you can logout manually at anytime by logout endpoint
5. you can show all stocks of the app without authentication
6. you can show any stock with comments without auhtentication

### **Now you authenticated and have account, you can the following operations**
1. create stock for your business
2. show all comments of the stock
3. can get all stcoks with comments of each one
4. get any stock by symbol, and also can get it by id
5. can filter stocks and sort them by by price and market value properties
6. can update and delete any stock
5. we use pagination for any get all endpoint

### for the comments
1. can get all comments of any users
2. can get show comments of another users
3. can create, update and delete comment
4. we also use pagination for any get all comments endpoints

### for the portfolio
1. can get, create and delete portfolio
2. the portfolio represent the M:M relation between the User & Stock

### **what we Use at The App**
1. Repository pattern
2. dependency injection
3. pagination, filters and sort
4. AspNet Identity
5. fluent validation api
6. EF core object relation mapper

#### Note: this is my first APi project and i make it simple because the goal of this project is to apply what i learn, and you find more advanced projects in another repos soon

 
