<Window x:Class="MyApp.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="MainWindow" Height="450" Width="800">
    <Grid>
        <TextBox Name="AddressTextBox" Width="200" Height="30" Margin="10"/>
        <TextBox Name="SearchTextBox" Width="200" Height="30" Margin="10,50,0,0"/>
        <ListBox Name="ProductListBox" Width="200" Height="200" Margin="10,100,0,0"/>
        <StackPanel Orientation="Horizontal" Margin="220,10,0,0">
            <Button Name="DecreaseButton" Content="-" Width="30" Click="DecreaseButton_Click"/>
            <TextBox Name="QuantityTextBox" Width="50" Text="0" HorizontalContentAlignment="Center"/>
            <Button Name="IncreaseButton" Content="+" Width="30" Click="IncreaseButton_Click"/>
        </StackPanel>
        <Button Name="SubmitButton" Content="Submit Order" Width="100" Height="30" Margin="10,310,0,0" Click="SubmitButton_Click"/>
    </Grid>
</Window>
