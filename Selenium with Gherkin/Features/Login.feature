Feature: Login
        Inicio de sesion de CelsiaOne

Scenario: Login sucessful
Given user is on CelsiaOne
When user logins on the portal
Then user should see the products