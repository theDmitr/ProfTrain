   M S B A M L   `   `   `  ����M  ITaskManager.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:TaskManager.Client.Views.PagesTaskManager.Client.Views.Pages  5      M+clr-namespace:TaskManager.Client.ViewModelsTaskManager.Client.ViewModels  5      U QLiveCharts.Wpf, Version=0.9.8.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5      -    'TaskManager.Client.Views.Pages.DashPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:TaskManager.Client.Views.Pages     5      :vm+clr-namespace:TaskManager.Client.ViewModels     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5        N� Title$  DashPage��5       � DataContext 5      1   +TaskManager.Client.ViewModels.DashViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��.15* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Дашборд��6   �� 5    
   $��1��6    �� CornerRadius$ 15��5!      $��2q�5"      
�������$��20q�5$       �� Padding$ 5q�5%      ._�5&      �� $��Center=�6   .+�5'      �� $��4��6   $��Center=�5(      $��Center=�5)      $��64(�5*      $
��Bold"�5+      �� 5,      $4��.Задачи выполнено сегодня��6    �� TextAlignment$ Center=�5-      $
��Wrap=�5.      $��Center=�5/      $��16(�50      $��DemiBold"�51      $	��150��62   52      53      �� 55   
   $��1��6   $��1��56      $ 15��57   	   $��2q�58   	   
�������$��20q�5:   	   $ 5q�5;      ._�5<      �� $	��Top=�6   .+�5=      �� $%��Топ 5 сотрудников��6   $ Center=�5>      $
��Wrap=�5?      $��Center=�5@      $��12(�5A      $��DemiBold"�5B      $��0,0,0,10q�5C      &   System.Windows.Controls.DataGrid  5E         AutoGenerateColumns$ False��6      
IsReadOnly$
 True��5F      	   Columns	 5G      0  *System.Windows.Controls.DataGridTextColumn  5H      ,  &System.Windows.Controls.DataGridColumn
   Header$	
 №��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$
 .25* 5I   .     5J      $
 ФИО��6-   $ * 5K   .     5L      $
 Кол-во��6-   $	 .4* 5M   .   5O      5P      5Q      �� 5S   
   $��1��6   $��2��5T      $ 15��5U      $��2q�5V      
�������$��20q�5X      $ 5q�5Y      ._�5Z      �� $	��Top=�6   .+�5[      �� $3��-График задач по статусам��6   $ Center=�5\      $
��Wrap=�5]      $��Center=�5^      $��12(�5_      $��DemiBold"�5`      $��0,0,0,10q�5a      #  LiveCharts.Wpf.CartesianChart  5b      $	��210��6%   64   5c      5d      �� 5f   
   $��2��6   $ 15��5g      $��2q�5h      
�������$��20q�5j      $ 5q�5k      ._�5l      �� $	��Top=�6   .+�5m      �� $!��Экспорт данных��6   $ Center=�5n      $
��Wrap=�5o      $��Center=�5p      $��12(�5q      $��DemiBold"�5r      $��0,0,0,10q�5s      �� 5u      $��Все задачи��6   $
 Left=�5v      $
��Wrap=�5w      $
��Left=�5x      $��12(�5y      $��DemiBold"�5z      �� 5|      $!��Все сотрудники��6   $
 Left=�5}      $
��Wrap=�5~      $
��Left=�5      $��12(�5�      $��DemiBold"�5�      �� 5�      $#��Закрытые задачи��6   $
 Left=�5�      $
��Wrap=�5�      $
��Left=�5�      $��12(�5�      $��DemiBold"�5�      5�      5�      �� 5�   
   $��2��6   $��1��5�      $��2��5�      $ 15��5�      $��2q�5�      
�������$��20q�5�      $ 5q�5�      ._�5�      �� .+�5�      �� $)��#Тепловая диаграмма��6   $ Center=�5�       $
��Wrap=�5�       $��Center=�5�       $	��Top=�5�       $��12(�5�       $��DemiBold"�5�       $��0,0,0,10q�5�         5�      $	��210��6<   &   LiveCharts.Wpf.Charts.Base.Chart   DataTooltip 6%   Z�    Series 5�        LiveCharts.Wpf.HeatSeries  	  LiveCharts.Wpf.Series 	  Values 6)   �� *Values+   GradientStopCollection 5�   "   �  � Offset$ 0Q�6/    � Color$ #b6bdff��6:   6L   � 5�   "   $	 .25Q�6/   $ #919cff��6<   6N   � 5�   "   $	 .50Q�6/   $ #6d7cff��6<   6N   � 5�   "   $	 .75Q�6/   $ #485bff��6<   6N   � 5�   "   $ 1Q�6/   $ #243aff��6:   6L   5�         AxisX 5�      
  LiveCharts.Wpf.Axis
   
  LabelsRotation$	 -15Q�6=    
  Labels 6#   �� *Months+ 
  	Separator 5�        LiveCharts.Wpf.Separator  5�   "      Step$ 1Q�60   6;   5�         AxisY 5�      
   6#   �� *Days+6=   5�      5�      5�      5�      5�      