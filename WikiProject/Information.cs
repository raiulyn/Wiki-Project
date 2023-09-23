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
    public class Information : IComparable<Information>, IComparer<Information>
    {
        private string name;
        private string category;
        private string structure;
        private string definition;

        public Information() { }
        public Information(string name, string category, string structure, string definition)
        {
            this.name = name;
            this.category = category;
            this.structure = structure;
            this.definition = definition;
        }

        // Comparers
        public int CompareTo(Information other)
        {
            return this.GetName().CompareTo(other.GetName());
        }
        public int Compare(Information x, Information y)
        {
            return x.GetName().CompareTo(y.GetName());
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
        public void SetName(string pData)
        {
            this.name = pData;
        }
        public void SetCategory(string pData)
        {
            this.category = pData;
        }
        public void SetStructure(string pData)
        {
            this.structure = pData;
        }
        public void SetDefinition(string pData)
        {
            this.definition = pData;
        }
    }
}
