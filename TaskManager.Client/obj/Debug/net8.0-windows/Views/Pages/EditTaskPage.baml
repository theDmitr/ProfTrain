   M S B A M L   `   `   `  ����M  ITaskManager.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:TaskManager.Client.Views.PagesTaskManager.Client.Views.Pages  5      M+clr-namespace:TaskManager.Client.ViewModelsTaskManager.Client.ViewModels  5      1    +TaskManager.Client.Views.Pages.EditTaskPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:TaskManager.Client.Views.Pages     5      :vm+clr-namespace:TaskManager.Client.ViewModels     5      $	��500��5
        N� Title$  EditTaskPage��5       � DataContext 5      2   ,TaskManager.Client.ViewModels.TasksViewModel  5   
   .��5      � .+�5   
   ��  �� CornerRadius$ 15��6   $��2q�5      
������� �� Padding$ 10q�5      ._�5      �� .+�5      �� $��16(�5      $
��Wrap=�5      ��5      �� *CurrentEditTask.FullTitle+5      � 5      $
��Left=�6   $	��100��62   $��40��6>   .+�5      �� $��10q�6   $ 8��5      ��5      �� *" CurrentEditTask.TaskStatus.Color+5      �� 5      $��Center=�5!      $��Center=�5"      $��12(�5#      
���������5       �� *!CurrentEditTask.TaskStatus.Name+5$      5%      �� 5'       �� Orientation$ 
Horizontal=�6   .+�5(      �� $%��Создание задачи: ��6    $��16(�5)      �� 5*      $��16(�5+      $
��Wrap=�5,      ��5*       �� *CurrentEditTask.CreatedTime+5,      5-      �� 5/      $ 
Horizontal=�6   .+�50      �� $��Дедлайн: ��6    $��16(�51      �� 52      $��16(�53      $
��Wrap=�54      ��52       �� *CurrentEditTask.DeadLine+54      55      �� 57      $)��#Предыдущая задача: ��6   $��16(�58      �� 59      $ 10��6   $��2q�5:      
�������$	��200��5<      $��25��5=      $
��Left=�5>      ._�5?      �� $��Center=�5@      ��5?      �� *%#CurrentEditTask.Previous.ShortTitle+5@      5A      �� 5C      $ 
Horizontal=�6   .+�5D      �� $@��:Фактическое начало выполнения: ��6    $��16(�5E      �� 5F      $��16(�5G      $
��Wrap=�5H      ��5F       �� *CurrentEditTask.StartTime+5H      5I      �� 5K      $ 
Horizontal=�6   .+�5L      �� $3��-Фактическое завершение: ��6    $��16(�5M      �� 5N      $��16(�5O      $
��Wrap=�5P      ��5N       �� *CurrentEditTask.FinishTime+5P      5Q      �� 5S      $��Описание��6   $��16(�5T      �� 5U      $ 10��6   $��2q�5V      
�������$	��300��5X      $
��Left=�5Y      ._�5Z      �� $��16(�5[       $
��Wrap=�5\       ��5Z       �� *CurrentEditTask.Description+5\       5]      �� 5_      $��Исполнитель��6   $��16(�5`      �� 5b      $ 10��6   $��2q�5c      
�������$	��200��5e      $��25��5f      $
��Left=�5g      ._�5h      �� $��Center=�5i      ��5h      �� *#!CurrentEditTask.Executor.FullName+5i      5j      �� 5l      $ 
Horizontal=�6   $��Center=�5m      $��30q�5n      .+�5o      �� -   5        $��34��5o      $	��146��6)   ���	#FF175AE0
�������$
��Bold"�5r      $��16(�5s      $��0,0,20,0q�5t      .��5u   6   Сохранить6A   �� 5v      -   5        $��34��5v      $	��146��6)   
������ 
���  ��$
��Bold"�5y      $��16(�5z      
���  ��$��3q�5{      .��5|   8   Удалить6A   5}      5~      5      5�      5�      