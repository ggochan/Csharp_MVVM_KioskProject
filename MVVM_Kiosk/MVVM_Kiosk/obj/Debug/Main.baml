   M S B A M L   `   `   `  ����E  AMVVM_Kiosk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MVVM_Kiosk
MVVM_Kiosk  5   	   1clr-namespace:MVVM_Kiosk.ViewMVVM_Kiosk.View  5   	   =#clr-namespace:MVVM_Kiosk.ViewModelsMVVM_Kiosk.ViewModels  5	   	       MVVM_Kiosk.Main   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   $localclr-namespace:MVVM_Kiosk  5   	   (Viewclr-namespace:MVVM_Kiosk.View  5   	   4
Viewmodels#clr-namespace:MVVM_Kiosk.ViewModels  5	   	   -   5          � 
ResizeMode$  NoResize=�5   	    � WindowStyle$
 None=�6    � WindowStartupLocation$ CenterScreen=�62    � AllowsTransparency . $	��800��5   	   $
��1000��6    � DataContext 5      %  MVVM_Kiosk.ViewModels.ViewModel  5   
   -   5        vm��5      .��5      �  � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $
��600* �6   �� 5      $	��300 �6   .+�5   
   � $��0��6   .+�5      ��    
Toolbar_sp#��[  6   .+�5      ��   Toolbar_Left_btn#��[ 6   .��5      "  FontAwesome.WPF.ImageAwesome     Icon$
 Home=�6&     Toolbar_left_btn_Icon#��[ 62   5      �� 5         Toolbar_Center_btn#��[ 6      WindowCloseCmd#��Z 6E   �� 5$        Toolbar_Right_btn#��[ 6      EnKoCmd#��Z 6E   ��6w   �� *EnKo+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=�5%      5&      � 5(   
   $��1��6     Brush_WhiteSmoke#��[ 6    � ColumnDefinitions 5*      �� 5+      $��60 �6#   �� 5,      $��* �6#   �� 5-      $��60 �6#    5/      �� 50      $��51 �6    �� 51      $��22 �6    �� 52      $��* �6    �� 53      $��32 �6    .+�56      �� $��0��6   $��0��6%     TabMenu_Side_btn#��[ 62   .��57        $ ChevronLeft=�6"     TabMenu_Side_Icon#��[ 65   58      �� 59      -   5         ��Name$ Main_TabMenu��59      $��1��6R    �� AlternationCount$ 1��6b   ��61   �� *
TabMenu_+��5:      �� 5;      .R�5<      ��  �� Orientation$ 
Horizontal=�6%   $��Center=�6>     Brush_Black#��[ 6Y   5=      ��5?      �� 5@      .R�5A         MVVM_Kiosk.View.TabButton  5B      ��5D      �� 5E      .R�5F      �� $��Hidden=�6(   $��Disabled=�6O   .��5G      �� 5H      5I      5K      �� 5L      $��2��6   $��0��6%   #��[ 62   .��5M        $ ChevronRight=�6"   #��[ 66   5N      �� 5P      -   5        $ 	Main_Menu��5P      $��1��6L   $��2��6\   $ 1��6i   ��6.   �� *Menu_+��5Q      �� 5R      .R�5S      �  � Orientation$ 
Horizontal=�6$   5T      ��5V      �� 5W      .R�5X          MVVM_Kiosk.View.MenuButton  5Y      ��5[      �� 5\      .R�5]      �� $��Hidden=�6'   .��5^      �� 5_      5`      5b      �� 5d      $��1��6   $��3��6)   $ 
Horizontal=�66   $��Center=�6O   $��Center=�6l   .+�5e      �� .��5f        $ Circle=�6&      
Foreground
 �����$��15��6K   $��15��6V   $	��3 0q�6b   5g      �� 5h      .��5i        $ Circle=�6&   
 �����$��15��6K   $��15��6V   $	��3 0q�6b   5j      �� 5k      .��5l        $ Circle=�6&   
 �����$��15��6K   $��15��6V   $	��3 0q�6b   5m      5n      5o      � 5p   
   $��2��6   .+�5q      �� 
�������6   5r      5s      5t      