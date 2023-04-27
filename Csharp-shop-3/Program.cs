using csharp_shop_2;

Console.OutputEncoding = System.Text.Encoding. Unicode;

try
{
	/*Console.WriteLine("I prodotti attualmente generati sono: " + Product.GetTotalGeneratedProducts());

	Product LavatriceSamsung = new Product("Lavatrice Samsung SE4000", "Lavatrice ultra performante in classe A", 999.99f, "elettrodomestico");
	Water AcquaSantAnna = new Water("Acqua", "Frizzante", 2f, "Alimentari", "Sant'Anna", 2.5f, 2f, 1f, "Vinadio");
	Fruit Limone = new Fruit("Limone", "Limone grande", 0.5f, "Alimentari", "Sicilia", "Agrume");
	Fruit Mela1 = new Fruit("Mela verde", "Mela rosso", 0.2f, "mela", "Roma", "frutta");
	Fruit Mela2 = new Fruit("Mela gialla", "Mela gialla", 0.2f, "mela", "Roma", "frutta");


	Fruit MelaSacchetto1 = new Fruit("Mela verde", "Mela verde", 0.2f, "mela", "Roma", "frutta");
	Fruit MelaSacchetto2 = new Fruit("Mela verde", "Mela verde", 0.2f, "mela", "Roma", "frutta");
	BagOfFruits sacchettoDiMele = new BagOfFruits("Il mio sacchetto di frutta", "Contiente 2 mele verdi", 0.02f, "frutta", "biodegradibile", 8);

	Console.WriteLine("I prodotti attualmente generati sono: " + Product.GetTotalGeneratedProducts());

	sacchettoDiMele.AddListOfFruitInbag(new List<Fruit> { MelaSacchetto1, MelaSacchetto2 });

	Console.WriteLine(LavatriceSamsung.GetDescription());
	Console.WriteLine(LavatriceSamsung.ToString());

	Console.WriteLine(AcquaSantAnna.GetLitersInBottle());
	AcquaSantAnna.Drink(0.5f);
	Console.WriteLine(AcquaSantAnna.GetLitersInBottle());
	Console.WriteLine(AcquaSantAnna.GetDescription());
	Console.WriteLine(AcquaSantAnna.ToString());

	Console.WriteLine(Limone.GetOrigin());

	Console.WriteLine(sacchettoDiMele.ToString());

	PhysicalShopCart mioCarrelloDellaSpesa = new PhysicalShopCart(20);
	PhysicalShopCart Carrello2 = new PhysicalShopCart(10);
	Console.WriteLine("Il numero di carrelli presenti è: " + PhysicalShopCart.GetNumberOfPhysicalShopCarts());

	mioCarrelloDellaSpesa.AddProduct(sacchettoDiMele);
	mioCarrelloDellaSpesa.AddProduct(Limone);
	mioCarrelloDellaSpesa.AddProduct(AcquaSantAnna);

	Console.WriteLine("STAMPIAMO IL CARRELLO");
	Console.WriteLine(mioCarrelloDellaSpesa.ToString());*/

	Shop Shop1 = new Shop("Eurospin", "Roma", "Via Paolo", "2");
	Water Acqua1 = new Water("Sant'Anna", "Frizzante", 2f, "Alimentare", "Sant'Anna", 2.5f, 2f, 7f, "Vinadio");
	Water Acqua2 = new Water("Lete", "Frizzante", 2f, "Alimentare", "Lete", 2.5f, 2f, 7f, "Ovunque");
	Fruit Mela1 = new Fruit("Mela", "Rossa", 0.5f, "Alimentare", "Roma", "Mela Rossa");
	Fruit Mela2 = new Fruit("Mela", "Gialla", 0.4f, "Alimentare", "Roma", "Mela Gialla");
	Fruit Arancia1 = new Fruit("Arancia", "Grande", 0.3f, "Alimentare", "Sicilia", "Grande");
	BagOfFruits Bag1 = new BagOfFruits("Sacchetto", "Plastica", 0.2f, "Plastica", "Plastica", 3);

	Bag1.AddFruitInBag(Mela1);
	Bag1.AddFruitInBag(Mela2);
	Bag1.AddFruitInBag(Arancia1);

	PhysicalShopCart Carrello1 = new PhysicalShopCart(10);


	Console.WriteLine(Carrello1.GetNUmbersOfProductsInCart());

	


	
} catch(Exception e)
{
	Console.WriteLine(e.ToString());
}









