using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace csharp_shop_2
{
	internal class PhysicalShopCart
	{
		private static int numberOfPhysicalShopCart = 0;
		private List<Product> productsInCart;
		private int maxProductsInCart;

		// COSTRUTTORE
		public PhysicalShopCart(int maxProductsInCart)
		{
			numberOfPhysicalShopCart++;
			this.maxProductsInCart = maxProductsInCart;
			this.productsInCart = new List<Product>();
		}

		// GETTERS
		public List<Product> GetProductListInsideCart()
		{
			return this.productsInCart;
		}

		public static int GetNumberOfPhysicalShopCarts()
		{
			return numberOfPhysicalShopCart;
		}

		// SETTERS

		// METHODS
		public int GetNUmbersOfProductsInCart()
		{
			return productsInCart.Count;
		}

		public void AddProduct(Product newProduct)
		{
			if (productsInCart.Count < maxProductsInCart)
			{
				this.productsInCart.Add(newProduct);
			} else
			{
				Console.WriteLine("Il carrello è pieno!");
			}
		}

		public void EmptyCart()
		{
			this.productsInCart.Clear();
		}

		public override string ToString()
		{
			string stringa = "--------- CARRELLO DELLA SPESA ---------\n";
			for (int i=0; i<this.productsInCart.Count; i++)
			{
				stringa += $"PRODOTTO {i+1}:\n";
				Product prodottoEstratto = productsInCart[i];

				if(prodottoEstratto is Fruit)
				{
					Fruit fruttoEstratto = (Fruit)prodottoEstratto;
					stringa += fruttoEstratto.ToString("newline");
				}else
				{
					stringa += prodottoEstratto.ToString();
				}

				stringa += "\n";
			}
			stringa += "---------------------------------";

			return stringa;
		}
	}
}
