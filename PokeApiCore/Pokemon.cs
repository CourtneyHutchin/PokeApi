using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeApiCore
{
    /// <summary>
    /// Represents a single Pokemon
    /// </summary>
    public class Pokemon
    {
        private const double InchesPerDecimetre = 3.937;
        private int height1;

        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// The base experience gained for defeating this Pokemon.
        /// </summary>
        public int base_experience { get; set; }
        /// <summary>
        /// The height of this Pokemon in inches
        /// </summary>
        public int Height { 
            // Height values are stored as decimetres
            get => (int)Math.Ceiling(height1 * InchesPerDecimetre); 
            set => height1 = value; 
        }

        /// <summary>
        /// Set for exactly one Pokémon used as the default for each species.
        /// </summary>
        public bool is_default { get; set; }
        public int order { get; set; }
        public int Weight { get; set; }
        public Ability[] abilities { get; set; }
        public Form[] forms { get; set; }
        public Game_Indices[] game_indices { get; set; }
        public Held_Items[] held_items { get; set; }
        public string location_area_encounters { get; set; }
        public Move[] moves { get; set; }
        public Species species { get; set; }
        public Sprites Sprites { get; set; }
        public Stat[] stats { get; set; }
        public Type[] types { get; set; }
    }

    public class Species
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Sprites
    {
        public string back_female { get; set; }
        public string back_shiny_female { get; set; }
        public string back_default { get; set; }
        public string front_female { get; set; }
        public string front_shiny_female { get; set; }
        public string back_shiny { get; set; }

        [JsonProperty("front_default")] // Manual Mapping
        public string FrontDefault { get; set; }
        public string front_shiny { get; set; }
    }

    public class Ability
    {
        public bool is_hidden { get; set; }
        public int slot { get; set; }
        public Ability1 ability { get; set; }
    }

    /// <summary>
    /// Name of the ability and link to more in-depth
    /// information about the ability
    /// </summary>
    public class Ability1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Form
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Game_Indices
    {
        public int game_index { get; set; }
        public Version version { get; set; }
    }

    public class Version
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Held_Items
    {
        public Item item { get; set; }
        public Version_Details[] version_details { get; set; }
    }

    public class Item
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Version_Details
    {
        public int rarity { get; set; }
        public Version1 version { get; set; }
    }

    public class Version1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Location_Area_Encounters
    {
        public Location_Area location_area { get; set; }
        public Version_Details1[] version_details { get; set; }
    }

    public class Location_Area
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Version_Details1
    {
        public int max_chance { get; set; }
        public Encounter_Details[] encounter_details { get; set; }
        public Version2 version { get; set; }
    }

    public class Version2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Encounter_Details
    {
        public int min_level { get; set; }
        public int max_level { get; set; }
        public Condition_Values[] condition_values { get; set; }
        public int chance { get; set; }
        public Method method { get; set; }
    }

    public class Method
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Condition_Values
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Move
    {
        public Move1 move { get; set; }
        public Version_Group_Details[] version_group_details { get; set; }
    }

    public class Move1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Version_Group_Details
    {
        public int level_learned_at { get; set; }
        public Version_Group version_group { get; set; }
        public Move_Learn_Method move_learn_method { get; set; }
    }

    public class Version_Group
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Move_Learn_Method
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Stat
    {
        public int base_stat { get; set; }
        public int effort { get; set; }
        public Stat1 stat { get; set; }
    }

    public class Stat1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Type
    {
        public int slot { get; set; }
        public Type1 type { get; set; }
    }

    public class Type1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

}
