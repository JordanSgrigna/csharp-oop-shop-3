using csharp_shop_2;

Console.OutputEncoding = System.Text.Encoding. Unicode;

try
{
	Console.WriteLine("I prodotti attualmente generati sono: " + Product.GetTotalGeneratedProducts());

	Product LavatriceSamsung = new Product("Lavatrice Samsung SE4000", "Lavatrice ultra performante in classe A", 999.99f, "elettrodomestico");
	Water AcquaSantAnna = new Water("Acqua", "Frizzante", 2f, "Alimentari", "Sant'Anna", 2.5f, 2f, -1f, "Vinadio");
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
	mioCarrelloDellaSpesa.AddProduct(sacchettoDiMele);
	mioCarrelloDellaSpesa.AddProduct(Limone);
	mioCarrelloDellaSpesa.AddProduct(AcquaSantAnna);

	Console.WriteLine("STAMPIAMO IL CARRELLO");
	Console.WriteLine(mioCarrelloDellaSpesa.ToString());
} catch(Exception e)
{
	Console.WriteLine(e.ToString());
}









