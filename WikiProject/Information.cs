using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// =========================================
/// 
/// Wiki Software v 2.0
/// 
/// Made by Raymond Lai
/// Student Code: 30082866
/// 
/// =========================================

namespace WikiProject
{
    // 6.1 Create a separate class file to hold the four data items of the Data Structure (use the Data Structure Matrix as a guide).
    // Use private properties for the fields which must be of type “string”. The class file must have separate setters and getters, add an appropriate IComparable for the Name attribute.
    // Save the class as “Information.cs”.

    [Serializable]
    internal class Information : IComparable<Information>
    {
        private string name;
        private string category;
        private string structure;
        private string definition;

        public Information() { }
        public Information(string _name, string _category, string _structure, string _definition)
        {
            this.name = _name;
            this.category = _category;
            this.structure = _structure;
            this.definition = _definition;
        }

        // Comparer
        public int CompareTo(Information _other)
        {
            return this.GetName().CompareTo(_other.GetName());
        }

        // Getters
        public string GetName()
        {
            return this.name;
        }
        public string GetCategory()
        {
            return this.category;
        }
        public string GetStructure()
        {
            return this.structure;
        }
        public string GetDefinition()
        {
            return this.definition;
        }

        // Setters
        public void SetName(string _data)
        {
            this.name = _data;
        }
        public void SetCategory(string _data)
        {
            this.category = _data;
        }
        public void SetStructure(string _data)
        {
            this.structure = _data;
        }
        public void SetDefinition(string _data)
        {
            this.definition = _data;
        }
    }
}
