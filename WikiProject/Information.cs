﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Information(string name, string category, string structure, string definition)
        {
            this.name = name;
            this.category = category;
            this.structure = structure;
            this.definition = definition;
        }

        public int CompareTo(Information other)
        {
            // TODO: Inital function. Need changes
            return 0;
        }

        public string GetData(int index)
        {
            switch (index)
            {
                case 0:
                    return this.name;
                case 1: 
                    return this.category;
                case 2: 
                    return this.structure;
                case 3: 
                    return this.definition;
                default:
                    return this.name;
            }
        }
        public void SetData(string name, string category, string structure, string definition)
        {
            this.name = name;
            this.category = category;
            this.structure = structure;
            this.definition = definition;
        }
    }
}