using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonSlaying
{
    public class ShopKeeper
    {
        public List<Item> Wares { get; set; }

        /// <summary>
        /// Constructs a new ShopKeeper object.
        /// </summary>
        /// <param name="wares">The initial List of Items the ShopKeeper has for sale.</param>
        public ShopKeeper(List<Item> wares)
        {
            Wares = wares;
        }

        /// <summary>
        /// Displays a menu of "trading" options, and calls appropriate methods to handle them based on user input.
        /// <para>Options should include "Buy", "Sell", and "Leave". Users should be presented with the list of options and select one by typing a number.</para>
        /// <para>If the use selects "Leave", the method should return. Otherwise, it should continue looping.</para>
        /// </summary>
        /// <param name="hero">The Hero object doing the trading.</param>
        public void Trade(Hero hero)
        {
            // TODO
        }

        /// <summary>
        /// Displays a menu of items for sale, reminds the user of the amount of Gold they have, and handles user choices based upon input.
        /// <para>Each item in the <see cref="Wares"/> list should be displayed in order, including the cost, and a final option should be for the user to go back.</para>
        /// <para>If the user chooses to buy an item, attempt to purchase it by using the <see cref="Buy(Hero, int)"/> method, passing in the appropriate choice. </para>
        /// <para>When the user chooses to go back, return from the method. Otherwise, loop.</para>
        /// </summary>
        /// <param name="hero">The Hero object doing the trading.</param>
        public void BuyMenu(Hero hero)
        {
            // TODO
        }

        /// <summary>
        /// Displays a menu of items in the Hero's inventory that could be sold, reminds the user of the amount of Gold they have, and handles user choices based upon input.
        /// <para>Each item in the <see cref="Hero.Inventory"/> list should be displayed in order, including the cost, and a final option should be for the user to go back.</para>
        /// <para>If the user chooses to sell an item, use the <see cref="Sell(Hero, int)"/> method, passing in the appropriate choice. </para>
        /// <para>When the user chooses to go back, return from the method. Otherwise, loop.</para>
        /// </summary>
        /// <param name="hero">The Hero object doing the trading.</param>
        public void SellMenu(Hero hero)
        {
            // TODO
        }

        /// <summary>
        /// Handles the process of buying an item from the ShopKeeper.
        /// <para>If the Hero has enough <see cref="Hero.Gold"/>, the cost of the item is subtracted from the Hero's <see cref="Hero.Gold"/>, the Item is removed from the ShopKeeper's <see cref="Wares"/>, and the Item is added to the Hero's <see cref="Hero.Inventory"/></para>
        /// <para>If the Hero does not have enough <see cref="Hero.Gold"/>, a message is printed out indicating that there isn't enough gold.</para>
        /// </summary>
        /// <param name="hero">The Hero object doing the buying.</param>
        /// <param name="itemIndex">The index of the item in the <see cref="Wares"/> list to be bought.</param>
        public void Buy(Hero hero, int itemIndex)
        {
            // TODO
            // TODO++: tell the user how much more gold they need to buy an item
        }

        /// <summary>
        /// Handles the process of a Hero selling an item to the ShopKeeper.
        /// <para>The Item is removed from the Hero's Inventory, its cost is added to the Hero's <see cref="Hero.Gold"/>, and the Item is added to the ShopKeeper's <see cref="Wares"/>.</para>
        /// </summary>
        /// <param name="hero">The Hero object doing the selling.</param>
        /// <param name="itemIndex">The index of the item in the Hero's <see cref="Hero.Inventory"/>.</param>
        public void Sell(Hero hero, int itemIndex)
        {
            // TODO
        }

    }
}
