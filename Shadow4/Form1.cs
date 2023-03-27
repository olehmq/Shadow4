using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shadow4
{
    public partial class Form1 : Form
    {
        private List<GameCharacter> characters;
        public Form1()
        {
            InitializeComponent();
            characters = new List<GameCharacter>
            {
                new GameCharacter("Мечник", "Ближній бій", 100),
                new GameCharacter("Лучник", "Дальній бій", 250),
                new GameCharacter("Гоблін", "Ближній бій", 300),
                new GameCharacter("Дракон", "Дальній бій", 600),
            };

            
            foreach (GameCharacter character in characters)
            {
                characterListBox.Items.Add(character.Name);
            }

          
            characterListBox.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void characterListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            int selectedIndex = characterListBox.SelectedIndex;
            GameCharacter selectedCharacter = characters[selectedIndex];
            characterDetailsLabel.Text = $"Name: {selectedCharacter.Name}\nConfiguration: {selectedCharacter.Configuration}\nPrice: ${selectedCharacter.Price}";
        
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
           
            int selectedIndex = characterListBox.SelectedIndex;
            GameCharacter selectedCharacter = characters[selectedIndex];

          
            bool paymentSuccessful = ProcessPayment(selectedCharacter.Price);

          
            if (paymentSuccessful)
            {
                MessageBox.Show($"Ви успішно здійснили покупку {selectedCharacter.Name} з {selectedCharacter.Configuration} configuration!");
            }
            else
            {
                MessageBox.Show("Платіж не вдався. Спробуйте ще раз.");
            }
        }
        private bool ProcessPayment(int amount)
        {
          
            return amount <= 100;
        }
        public class GameCharacter
        {
            public string Name { get; }
            public string Configuration { get; }
            public int Price { get; }

            public GameCharacter(string name, string configuration, int price)
            {
                Name = name;
                Configuration = configuration;
                Price = price;
            }
        }
    }
}
