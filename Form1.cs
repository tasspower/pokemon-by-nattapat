using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace pikachu
{
    public partial class Form1 : Form
    {
        Dictionary<string, (string Type, string Status, Image Image)> pokemons;

        public Form1()
        {
            InitializeComponent();
            LoadPokemonData();
            RegisterEventHandlers(); // ⭐ เพิ่มการเชื่อม Event Handler
        }

        // ✅ เพิ่มการกำหนด Event ให้กับปุ่ม
        private void RegisterEventHandlers()
        {
            btnPikachu.Click += (s, e) => DisplayPokemonData("Pikachu");
            btnCharmander.Click += (s, e) => DisplayPokemonData("Charmander");
            btnSquirtle.Click += (s, e) => DisplayPokemonData("Squirtle");
            btnkabigon.Click += (s, e) => DisplayPokemonData("Snorlax");
            btnJigglypuff.Click += (s, e) => DisplayPokemonData("Jigglypuff");
            btnEevee.Click += (s, e) => DisplayPokemonData("Eevee");
        }

        // ✅ เพิ่มข้อมูล Pokémon
        private void LoadPokemonData()
        {
            pokemons = new Dictionary<string, (string Type, string Status, Image Image)>()
            {
                { "Pikachu", ("Electric", "HP: 35, Attack: 55", Properties.Resources.ปิกาชู) },
                { "Charmander", ("Fire", "HP: 39, Attack: 52", Properties.Resources.Charmander) },
                { "Squirtle", ("Water", "HP: 44, Attack: 48", Properties.Resources.sq) },
                { "Snorlax", ("Normal", "HP: 160, Attack: 110", Properties.Resources.kabigon) },
                { "Jigglypuff", ("Normal/Fairy", "HP: 115, Attack: 45", Properties.Resources.ชมพู) },
                { "Eevee", ("Normal", "HP: 55, Attack: 55", Properties.Resources.Eevee) }
            };
        }

        // ✅ เพิ่มเงื่อนไขกัน Error หากไม่มีข้อมูล
        private void DisplayPokemonData(string name)
        {
            if (pokemons != null && pokemons.ContainsKey(name))
            {
                var data = pokemons[name];
                pictureBoxPokemon.Image = data.Image;
                labelName.Text = name;
                labelType.Text = $"Type: {data.Type}";
                labelStatus.Text = $"Basic Status: {data.Status}";
            }
            else
            {
                MessageBox.Show("Pokemon data not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ เพิ่มการโหลดข้อมูลเริ่มต้นเมื่อเปิดฟอร์ม
        private void Form1_Load(object sender, EventArgs e)
        {
            labelName.Text = "Select a Pokemon";
            labelType.Text = "Type";
            labelStatus.Text = "Basic Status";
            pictureBoxPokemon.Image = null;
        }
    }
}
