# How-to-Customize-the-Overlay-Color-of-the-.NET-MAUI-Bottom-Sheet
This sample demonstrates how to customize the overlay color of the .NET MAUI Bottom Sheet control within a .NET MAUI application.

**Define the Overlay Color in App.xaml**

Set the overlay color using a resource key called SfBottomSheetOverlayBackgroundColor. In this example, a light green (#90EE90) color is used.

```
<?xml version = "1.0" encoding = "UTF-8" ?>
<Application xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:BottomSheetSample"
             x:Class="BottomSheetSample.App">
    <Application.Resources>
        <ResourceDictionary>
            <!-- Set light green overlay color -->
            <Color x:Key="SfBottomSheetOverlayBackgroundColor">#90EE90</Color>

            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="Resources/Styles/Colors.xaml" />
                <ResourceDictionary Source="Resources/Styles/Styles.xaml" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application

```
**Configure the Bottom Sheet in MainPage.xaml**

Create a list and show book details in the bottom sheet when an item is tapped.

```
 <Grid>
        <Grid.BindingContext>
            <local:BookViewModel/>
        </Grid.BindingContext>

        <ListView ItemsSource="{Binding Books}" ItemTapped="ListView_ItemTapped" HasUnevenRows="True">
            <ListView.ItemTemplate>
                <DataTemplate>
                    <ViewCell>
                        <Grid ColumnDefinitions="*, 60" Padding="10">
                            <VerticalStackLayout>
                                <Label Text="{Binding Title}" FontSize="20" FontAttributes="Bold"/>
                                <Label Text="{Binding Description}" FontSize="14" TextColor="Gray"/>
                            </VerticalStackLayout>
                            <Label Text="{Binding Rating, StringFormat='{}{0} / 5'}" Grid.Column="1" HorizontalOptions="Center" VerticalOptions="Center"/>
                        </Grid>
                    </ViewCell>
                </DataTemplate>
            </ListView.ItemTemplate>
        </ListView>

        <bottomSheet:SfBottomSheet x:Name="bottomSheet" ContentPadding="10">
            <bottomSheet:SfBottomSheet.BottomSheetContent>
                <VerticalStackLayout Spacing="5" x:Name="bottomSheetContent">
                    <Grid ColumnDefinitions="120, *" ColumnSpacing="10">
                        <Label Text="Title:" FontSize="20" FontAttributes="Bold"/>
                        <Label Text="{Binding Title}" FontSize="16" VerticalTextAlignment="Center" Grid.Column="1"/>
                    </Grid>
                    <Grid ColumnDefinitions="120, *" ColumnSpacing="10">
                        <Label Text="Genre:" FontSize="20" FontAttributes="Bold"/>
                        <Label Text="{Binding Genre}" FontSize="16" VerticalTextAlignment="Center" Grid.Column="1"/>
                    </Grid>
                    <Grid ColumnDefinitions="120, *" ColumnSpacing="10">
                        <Label Text="Published:" FontSize="20" FontAttributes="Bold"/>
                        <Label Text="{Binding Published}" FontSize="16" VerticalTextAlignment="Center" Grid.Column="1"/>
                    </Grid>
                    <Grid ColumnDefinitions="120, *" ColumnSpacing="10">
                        <Label Text="Description:" FontSize="20" FontAttributes="Bold"/>
                        <Label Text="{Binding Description}" FontSize="16" VerticalTextAlignment="Center" Grid.Column="1"/>
                    </Grid>
                    <Grid ColumnDefinitions="120, *" ColumnSpacing="10">
                        <Label Text="Price:" FontSize="20" FontAttributes="Bold"/>
                        <Label FontSize="16" VerticalTextAlignment="Center" Grid.Column="1">
                            <Label.FormattedText>
                                <FormattedString>
                                    <Span Text="$" FontAttributes="Bold" />
                                    <Span Text="{Binding Price, StringFormat='{0:F2}'}" />
                                </FormattedString>
                            </Label.FormattedText>
                        </Label>
                    </Grid>
                </VerticalStackLayout>
            </bottomSheet:SfBottomSheet.BottomSheetContent>
        </bottomSheet:SfBottomSheet>

    </Grid>
```

**Handle Item Tapped Event in MainPage.xaml.cs**

Set the binding context of the bottom sheet and display it:

```
private void ListView_ItemTapped(object? sender, ItemTappedEventArgs e)
{
    bottomSheet.BottomSheetContent.BindingContext = e.Item;
    bottomSheet.Show();
}
```
