using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowBagSimulator.MODEL;

namespace WowBagSimulator.VIEWMODEL
{
    class ListAvailableItems: BindableBase
    {
        public ObservableCollection<Items> AvailableItems { get; set; } //kolekcja zostaje poinformowana jeśli coś się zmieni

        public ListAvailableItems()
        {

            Items Miecz = new Items();
            Miecz.Name = "Miecz";
            Miecz.Icon = "http://wow.zamimg.com/images/wow/icons/large/inv_sword_04.jpg";
            Miecz.MaxStack = 1;
            Miecz.ItemCount = 1;


            Items Topor = new Items();
            Topor.Name = "Topor";
            Topor.Icon = "http://wow.zamimg.com/images/wow/icons/large/inv_axe_19.jpg";
            Miecz.MaxStack = 1;


            Items Helm = new Items();
            Helm.Name = "Helm";
            Helm.Icon = "http://wow.zamimg.com/images/wow/icons/large/inv_helmet_20.jpg";
            Helm.MaxStack = 1;

            Items Pancerz = new Items();
            Pancerz.Name = "Pancerz";
            Pancerz.Icon = "http://wow.zamimg.com/images/wow/icons/large/inv_chest_chain.jpg";
            Pancerz.MaxStack = 1;

            Items Pasek = new Items();
            Pasek.Name = "Pasek";
            Pasek.Icon = "http://wow.zamimg.com/images/wow/icons/large/inv_belt_03.jpg";
            Pasek.MaxStack = 1;

            Items Buty = new Items();
            Buty.Name = "Buty";
            Buty.Icon = "http://wow.zamimg.com/images/wow/icons/large/inv_boots_07.jpg";
            Buty.MaxStack = 1;

            Items Bransolety = new Items();
            Bransolety.Name = "Bransolety";
            Bransolety.Icon = " http://wow.zamimg.com/images/wow/icons/large/inv_bracer_03.jpg";
            Bransolety.MaxStack = 1;

            Items LnianaTkanina = new Items();
            LnianaTkanina.Name = "Lniana Tkanina";
            LnianaTkanina.Icon = "http://wow.zamimg.com/images/wow/icons/large/inv_fabric_linen_01.jpg";
            

            Items Pioro = new Items();
            Pioro.Name = "Pioro";
            Pioro.Icon = "http://wow.zamimg.com/images/wow/icons/large/inv_feather_01.jpg";
            Pioro.MaxStack = 100;

            Items Zloto = new Items();
            Zloto.Name = "Zloto";
            Zloto.Icon = "http://wow.zamimg.com/images/wow/icons/large/inv_ingot_05.jpg";
            Zloto.MaxStack = 20;

            Items Skrzynia = new Items();
            Skrzynia.Name = "Skrzynia";
            Skrzynia.Icon = "http://wow.zamimg.com/images/wow/icons/large/inv_crate_02.jpg";
            Skrzynia.MaxStack = 20;

            Items Krysztal = new Items();
            Krysztal.Name = "Krysztal";
            Krysztal.Icon = "http://wow.zamimg.com/images/wow/icons/large/inv_datacrystal02.jpg";
            Krysztal.MaxStack = 100;

            Items Piwo = new Items();
            Piwo.Name = "Piwo";
            Piwo.Icon = "http://wow.zamimg.com/images/wow/icons/large/inv_drink_08.jpg";
            Piwo.MaxStack = 20;

            Items Chleb = new Items();
            Chleb.Name = "Chlec";
            Chleb.Icon = " http://wow.zamimg.com/images/wow/icons/large/inv_misc_food_11.jpg";
            Chleb.MaxStack = 20;

            Items Stek = new Items();
            Stek.Name = "Stek";
            Stek.Icon = "http://wow.zamimg.com/images/wow/icons/large/inv_misc_food_82.jpg";
            Stek.MaxStack = 20;


            AvailableItems = new ObservableCollection<Items>();
            AvailableItems.Add(Miecz);
            AvailableItems.Add(Topor);
            AvailableItems.Add(Helm);
            AvailableItems.Add(Pancerz);
            AvailableItems.Add(Pasek);
            AvailableItems.Add(Buty);
            AvailableItems.Add(Bransolety);
            AvailableItems.Add(LnianaTkanina);
            AvailableItems.Add(Pioro);
            AvailableItems.Add(Zloto);
            AvailableItems.Add(Skrzynia);
            AvailableItems.Add(Krysztal);
            AvailableItems.Add(Piwo);
            AvailableItems.Add(Chleb);
            AvailableItems.Add(Stek);


        }
    }
}
