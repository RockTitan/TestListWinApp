using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestListWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> str1 = new List<string>();
            List<string> str2 = new List<string>();
            str1.Add("FUCK");
            str1.Add("lb");
            str1.Add("sorr");

            str2.Add("FUCK");
            str2.Add("12");

            str1.AddRange(str2);

            foreach (string s in str1.Distinct<string>())
            {
                MessageBox.Show(s);
            }
        }

        public static List<PropG1> T1List = new List<PropG1>();
        public static List<PropG2> T2List = new List<PropG2>();

        private void button2_Click(object sender, EventArgs e)
        {
            T1List.Add(new PropG1
            {
                title1 = "Name",
                A = 000,
                Score1 = 59.999
            });

            T2List.Add(new PropG2
            {
                title2 = "Name",
                B = 123,
                Score2 = 87.023
            });

        }

        public string input = "";

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(int.Parse(input).ToString()); //input不可為空字串
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToInt32(input).ToString()); //input不可為空字串
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Create a list of parts.
            List<Part> parts = new List<Part>();

            // Add parts to the list.
            parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
            parts.Add(new Part() { PartName = "chain ring", PartId = 1334 });
            parts.Add(new Part() { PartName = "regular seat", PartId = 1434 });
            parts.Add(new Part() { PartName = "banana seat", PartId = 1444 });
            parts.Add(new Part() { PartName = "cassette", PartId = 1534 });
            parts.Add(new Part() { PartName = "shift lever", PartId = 1634 });

            // Write out the parts in the list. This will call the overridden ToString method
            // in the Part class.
            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }


            // Check the list for part #1734. This calls the IEquitable.Equals method
            // of the Part class, which checks the PartId for equality.
            Console.WriteLine("\nContains(\"1734\"): {0}",
            parts.Contains(new Part { PartId = 1734, PartName = "" }));

            // Insert a new item at position 2.
            Console.WriteLine("\nInsert(2, \"1834\")");
            parts.Insert(2, new Part() { PartName = "brake lever", PartId = 1834 });


            //Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            Console.WriteLine("\nParts[3]: {0}", parts[3]);

            Console.WriteLine("\nRemove(\"1534\")");

            // This will remove part 1534 even though the PartName is different,
            // because the Equals method only checks PartId for equality.
            parts.Remove(new Part() { PartId = 1534, PartName = "cogs" });

            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }
            Console.WriteLine("\nRemoveAt(3)");
            // This will remove the part at index 3.
            parts.RemoveAt(3);

            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }
        }
    }
}
