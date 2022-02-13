using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "localDbDataSet.Animal". При необходимости она может быть перемещена или удалена.
            this.animalTableAdapter.Fill(this.localDbDataSet.Animal);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal();
            animal.name = textBox1.Text;
            animal.surname = textBox2.Text;
            animal.view = textBox3.Text;
            localDbEntities _db = new localDbEntities();
            _db.Animal.Add(animal);
            _db.SaveChanges();
           // dataGridView1.Refresh();

            List<Animal> animalList = new List<Animal>();
            animalList = _db.Animal.ToList();
            dataGridView1.DataSource = animalList;

        }
    }
}
