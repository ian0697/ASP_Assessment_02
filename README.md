# AspFundamentalsApplication
A simple web app applying the fundamentals of ASP.Net

## This web app includes:
* Login form
* Registration form
* Members page
* Transaction page

## ASP.Net fundamentals covered:
* [Application of ASP.Net Session](#session)
  * [Initializing session](#)
  * [Access session](#)
* [Accessing controls of webforms](#)
  * [Access asp.net controls](#)
  * [Acess div elements](#)
* [CSS Manipulation in code behind](#CSS)
  * [Adding classes](#)
  * [Access session](#)
* [Avoiding variable value refresh during postback](#)  
  * [Static variables](#)
* [Validation Controls](#Validation-control)
  * [RequiredFieldValidator](#)
  * [RangeValidator](#)
  * [CompareValidator](#)
  * [CustomValidator](#)
* [Using repeater control (Advanced)](#)
* [Others](#)
  * [Redirecting to other page](#)
  
## Validation control
Using validation control allows you to validate associate input control and create a custom error message for an invalid user input.
It is one of the important functions in Asp.Net especially for validating TextBox controls

### RequiredFieldValidator
This validation control allows you to check whether a user has typed something in an input control such as a TextBox.

For example, in Registration.aspx, this validator was applied to the TextBox named TbFirstName. The RequiredFieldValidator was positioned below the asp:TextBox tag. This means that if the user doesn't type anything in the TextBox, the RequiredFieldValidator will trigger the page as an **Invalid**

_In this Web app, the requiredfield validator was applied in all TextBox control in Login.aspx as well as in Registration.aspx_

```html
<div class="form-group">
   <label>Last Name:</label>
   <asp:TextBox ID="TbFirstName" runat="server"></asp:TextBox>
   <asp:RequiredFieldValidator 
        Display="Dynamic" 
        runat="server" 
        ControlToValidate="TbFirstName" 
        ErrorMessage="*Required field" />
</div>
```

> runat="server" code in asp.net controls is **extremely important**

Now let us focus on the RequiredFieldValidator tag:
```html
 <asp:RequiredFieldValidator 
        Display="Dynamic" 
        runat="server" 
        ControlToValidate="TbFirstName" 
        ErrorMessage="*Required field" />
```
In this example, there are different properties associated with RequiredFieldValidator:
* **Display** - This property will give you a value of: _Dynamic_ and _Static_. 
  * Static - If set to static, the Error Message to be displayed will always show even if the validator isn't triggering yet.
  * Dynamic - Otherwise, if it is Dynamic, the error message of this validator will ONLY display if the validator triggers an invalid input. Which is in this case, the user doesn't input anything in the TextBox.
* **ControlToValidate** - this property accepts the id of the Input control to be validated. 
* **ErrorMessage** - the error message to be displayed if page is invalid.



