﻿namespace FtdiSharpDemo;

public partial class MenuForm : Form
{
    public MenuForm()
    {
        InitializeComponent();
    }

    private void btnConnectedDevices_Click(object sender, EventArgs e) => new DeviceInfoForm().ShowDialog();
    private void btnAddressScanner_Click(object sender, EventArgs e) => new I2C_Scan().ShowDialog();
    private void btnLM75A_Click(object sender, EventArgs e) => new I2C_LM75A().ShowDialog();
    private void btnBMP280_Click(object sender, EventArgs e) => new I2C_BMP280().ShowDialog();
    private void btnLIS3DH_Click(object sender, EventArgs e) => new I2C_LIS3DH().ShowDialog();
    private void btnADS1115_Click(object sender, EventArgs e) => new I2C_ADS1115().ShowDialog();
    private void btnADS1115DataLogger_Click(object sender, EventArgs e) => new I2C_ADS1115DataLogger().ShowDialog();
    private void lblBH1750_Click(object sender, EventArgs e) => new I2C_BH1750().ShowDialog();
    private void btnMCP3201_Click(object sender, EventArgs e) => new SPI_MCP3201().ShowDialog();
    private void btnHX710_Click(object sender, EventArgs e) => new SPI_HX710().ShowDialog();
    private void btnMCP3008_Click(object sender, EventArgs e) => new SPI_MCP3008().ShowDialog();
    private void btnAD7705_Click(object sender, EventArgs e) => new SPI_AD7705().ShowDialog();
    private void btnADS1220_Click(object sender, EventArgs e) => new SPI_ADS1220().ShowDialog();
    private void btnLED_Click(object sender, EventArgs e) => new GPIO_LED().ShowDialog();
}
