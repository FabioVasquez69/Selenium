Feature: SearchProduct
        Buscar un Producto en Mis Productos

Scenario: SearchProduct Product found
  Given user is on Mis productos
  When user is doing a search
  Then user should see the product that he searched