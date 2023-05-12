using inventar;

Inventory inventory = new Inventory(6); // muzete si nastavit velikost inventare

inventory.AddProduct("Jablko", 12.0);
inventory.AddProduct("Banán", 14.0);
inventory.AddProduct("Pomeranč", 20.0);
inventory.AddProduct("Hruška", -1.0); // error, cena nemuze byt zaporna
inventory.AddProduct("Ananas", 24.0);
inventory.AddProduct("Mango", 32.0);
inventory.AddProduct("Jablko", 12.0); // error, produkt jiz existuje v inventari
inventory.AddProduct("Broskev", 25.0); // error, inventar je plny
inventory.AddProduct("Meloun", 50.0);

inventory.RemoveProduct("Pomeranč");
inventory.RemoveProduct("Jablko");
inventory.RemoveProduct("Auto"); // error, produkt neexistuje