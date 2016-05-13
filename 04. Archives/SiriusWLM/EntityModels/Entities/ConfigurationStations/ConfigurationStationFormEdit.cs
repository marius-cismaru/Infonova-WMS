using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Sirius.EntityModels.ConfigurationStations
{
    public partial class ConfigurationStationFormEdit : CustomControls.EntityFormEdit
    {
        private EntityModelSirius Model;
        private new ConfigurationStation Entity {
            get { return base.Entity as ConfigurationStation; }
            set { base.Entity = value; }
        }

        public ConfigurationStationFormEdit()
            : base()
        {
            InitializeComponent();
            Model = new EntityModelSirius(Configuration.Main.SQLConnectionString);
        }

        public override void FormEdit_Shown(object sender, EventArgs e)
        {
            Entity = ConfigurationStationCollection.GetById(Model, EntityId, true);
            SetFormName(ConfigurationStationCollection.EntityNameSingular);
            base.FormEdit_Shown(sender, e);
        }

        public override void LoadFieldsFromEntity()
        {
            textBoxStationName.Text = Environment.MachineName.ToUpper();
            textBoxLabelPrinterName.Text = Entity.LabelPrinterName;
            comboBoxSerialPortName.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            comboBoxSerialPortName.Text = Entity.SerialPortName;
            textBoxSerialPortBaudRate.Text = Entity.SerialPortBaudRate.ToString();
            textBoxSerialPortDataBits.Text = Entity.SerialPortDataBits.ToString();
            CommonLibs.EnumsLib.PopulateSelectBox<System.IO.Ports.Parity>(selectBoxSerialPortParity, Entity.OptionSerialPortParity);
            CommonLibs.EnumsLib.PopulateSelectBox<System.IO.Ports.StopBits>(selectBoxSerialPortStopBits, Entity.OptionSerialPortStopBits);
            CommonLibs.EnumsLib.PopulateSelectBox<System.IO.Ports.Handshake>(selectBoxSerialPortFlowControl, Entity.OptionSerialPortFlowControl);
        }

        public override bool SaveFieldsToEntity()
        {
            bool result = false;
            if (!ConfigurationStations.ConfigurationStationCollection.CheckIfExistsByStationNameExceptSelf(textBoxStationName.Text, Entity.Id))
            {
                int serialPortBaudRate = 0, serialPortDataBits = 0;
                Entity.LabelPrinterName = textBoxLabelPrinterName.Text.Trim();
                Entity.SerialPortName = comboBoxSerialPortName.Text.Trim().ToUpper();
                int.TryParse(textBoxSerialPortBaudRate.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out serialPortBaudRate);
                Entity.SerialPortBaudRate = serialPortBaudRate;
                int.TryParse(textBoxSerialPortDataBits.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out serialPortDataBits);
                Entity.SerialPortDataBits = serialPortDataBits;
                Entity.OptionSerialPortParity = CommonLibs.EnumsLib.GetSelectBoxSelectedEnum<System.IO.Ports.Parity>(selectBoxSerialPortParity);
                Entity.OptionSerialPortStopBits = CommonLibs.EnumsLib.GetSelectBoxSelectedEnum<System.IO.Ports.StopBits>(selectBoxSerialPortStopBits);
                Entity.OptionSerialPortFlowControl = CommonLibs.EnumsLib.GetSelectBoxSelectedEnum<System.IO.Ports.Handshake>(selectBoxSerialPortFlowControl);

                if (Entity.Id == 0)
                {
                    Entity.StationName = textBoxStationName.Text;
                    Model.ConfigurationStations.AddObject(Entity);
                }
                Model.SaveChanges();
                result = true;
            }
            else
            {
                MessageBox.Show("O configuratie pentru aceasta statie de lucru mai exista deja. Incearca editarea acelei configuratii.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            return result;
        }

        private void buttonLabelPrinterBrowse_Click(object sender, EventArgs e)
        {
            using (PrintDialog dialog = new PrintDialog())
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    textBoxLabelPrinterName.Text = dialog.PrinterSettings.PrinterName;
                }
            }
        }
    }
}
