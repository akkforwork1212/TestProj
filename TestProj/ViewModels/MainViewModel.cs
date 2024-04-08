using CommunityToolkit.Mvvm.Input;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TestProj.Models;

namespace TestProj.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public ObservableCollection<TableModel> Rows { get; }

    public MainViewModel()
    {
        Rows = new ObservableCollection<TableModel>();
        InitTable();
    }

    // Обработчик добавления строки
    [RelayCommand]
    private void ClickBtn()
    {
        // Берешь данные из БД 
        // Потом добавляешь в цикле, как ниже
        Rows.Add(new TableModel() { Column1 = "text", Column2 = "text" });
    }

    // Обработчик очистки
    [RelayCommand]
    private void ClearTable()
    {
        Rows.Clear();
    }

    // Инициализация
    void InitTable()
    {
        Rows.Add(new TableModel() { Column1 = "text", Column2 = "text" });
        Rows.Add(new TableModel() { Column1 = "text", Column2 = "text" });
        Rows.Add(new TableModel() { Column1 = "text", Column2 = "text" });
    }
}
