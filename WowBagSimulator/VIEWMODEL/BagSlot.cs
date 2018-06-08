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
    class SlotBag : BindableBase
    {
        public List<Bag> Slot1 = new List<Bag>();
        public List<Bag> Slot2 = new List<Bag>();

        public SlotBag()
        {
            Bag Torba1 = new Bag();
            Torba1.BagName = "Torba o pojemnosci 4";
            Torba1.BagIcon = " http://wow.zamimg.com/images/wow/icons/large/inv_misc_bag_09_green.jpg";
            Torba1.BagSpace = 4;

            Bag Torba2 = new Bag();
            Torba2.BagName = "Torba o pojemnosci 6";
            Torba2.BagIcon = "http://wow.zamimg.com/images/wow/icons/large/inv_misc_bag_07.jpg";
            Torba2.BagSpace = 6;

            Bag Torba3 = new Bag();
            Torba3.BagName = "Torba o pojemnosci 8";
            Torba3.BagIcon = "http://wow.zamimg.com/images/wow/icons/large/inv_misc_bag_05.jpg";
            Torba3.BagSpace = 8;

            Bag Torba4 = new Bag();
            Torba4.BagName = "Torba o pojemnosci 10";
            Torba4.BagIcon = "http://wow.zamimg.com/images/wow/icons/large/inv_misc_bag_20.jpg";
            Torba4.BagSpace = 10;

            Bag Torba5 = new Bag();
            Torba5.BagName = "Torba o pojemnosci 12";
            Torba5.BagIcon = "http://wow.zamimg.com/images/wow/icons/large/inv_misc_bag_26_spellfire.jpg";
            Torba5.BagSpace = 12;

            Slot1.Add(Torba1);
            Slot1.Add(Torba2);
            Slot1.Add(Torba3);

            Slot2.Add(Torba4);
            Slot2.Add(Torba5);

        }

    }
}
