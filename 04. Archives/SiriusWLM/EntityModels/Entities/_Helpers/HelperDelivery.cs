using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels
{
    public class HelperDelivery
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int OrderType { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string RepresentativeName { get; set; }
        public string RepresentativeID { get; set; }
        public string Conveyance { get; set; }
        public string Seal { get; set; }
        public string Comment { get; set; }
        public DateTime DateCreation { get; set; }
        public int Client_Id { get; set; }
        public int Warehouse_Id { get; set; }
        public int User_Id { get; set; }
        public int ClientDestination_Id { get; set; }

        public int StepCurrent { get; set; }

        public List<HelperDeliveryOrderProduct> DeliveryOrderProducts { get; set; }

        public enum OptionsPickingMethod
        {
            [Description("Automatic FIFO")]
            AutomaticFIFO = 1,

            [Description("Manual")]
            Manual = 2
        }

        public OptionsPickingMethod OptionPickingMethod { get; set; }

        public int PickingMethod
        {
            get { return (int)OptionPickingMethod; }
            set { OptionPickingMethod = (OptionsPickingMethod)value; }
        }

        public string OptionPickingMethodDescription
        {
            get { return CommonLibs.EnumsLib.GetDescription(OptionPickingMethod); }
        }

        public enum OptionsQuantityPolicy
        {
            [Description("Acceptare livrare supra-cantitati")]
            AllowOverDelivery = 1,

            [Description("Obligativitate livrare sub-cantitati")]
            EnforceUnderDelivery = 2,

            [Description("Obligativitate cantitati exacte")]
            EnforceExact = 3
        }

        public OptionsQuantityPolicy OptionQuantityPolicy { get; set; }

        public int QuantityPolicy
        {
            get { return (int)OptionQuantityPolicy; }
            set { OptionQuantityPolicy = (OptionsQuantityPolicy)value; }
        }

        public string OptionQuantityPolicyDescription
        {
            get { return CommonLibs.EnumsLib.GetDescription(OptionQuantityPolicy); }
        }

        public HelperDelivery()
        {
            Id = 0;
            OrderDate = DateTime.Now;
            DateCreation = DateTime.Now;
            User_Id = 5; //Laurentiu Popescu
            Warehouse_Id = 1;

            //Current step in add wizard process
            StepCurrent = 1;

            //Init lists
            DeliveryOrderProducts = new List<HelperDeliveryOrderProduct>();

            //Options
            OptionQuantityPolicy = OptionsQuantityPolicy.AllowOverDelivery;
            OptionPickingMethod = OptionsPickingMethod.AutomaticFIFO;
        }
    }
}
