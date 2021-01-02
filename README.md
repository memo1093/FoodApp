# FoodApp

A basic food shopping app created with Entityframework.Core

This uses Entityframework.Core 3.1.403

# Usage

You can pull repository and can be use with ready components. First you need to write console this Efcore commands for create database. 

dotnet ef database update -s ../foodapp.webui --context FoodContext


Project already has account member for all roles(admin/master/user) account. This account is:

username : foodapp_admin
password : Foodapp_159357456

You can change everything in database but you can delete or update orders(order state can be change). 



![Alt Text](https://media.giphy.com/media/9Z0r4oV20H57RCpMXA/giphy.gif)



If you want to application membership system you need go to appsettings.json and then change these fields in "EmailSender"
*Note: You can use any email when you will be a member but if you want to send emails, email sender just supports @windowslive.com and @hotmail.com.

![Alt Text](https://i.ibb.co/hsb0xpm/emailsender.jpg)







