   M S B A M L   `   `   `  ����C  ?Project1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Project_one_EADProject_one_EAD  5          Project_one_EAD.Admin   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Project_one_EAD     5        N� Title$  Admin��5	      .��5      � ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ #E8F0FF��6    � Offset$ 0Q�6/   � 5      $ #D3E1FF��6   $
 0.75Q�6/   � 5      $ #A3C1FF��6   $ 1Q�6/   5       � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��10q�6   .+�5      �� $��
Guard List��6   $��20(�6*   $
��Bold"�68   $��0,0,0,10q�6J   �� 5      $
��Auto=�6   $��Disabled=�6>   $	��200��6g   .��5      &   System.Windows.Controls.DataGrid  -   5          Name$ GuardListDataGrid��5         AutoGenerateColumns$ False��66   $��0,0,0,10q�6R   ���#C9E2FF   AlternatingRowBackground �#BDD7FD	   RowBackground	 �#C9E2FF���#8DA9C4$��1q�5    �   
   RowHeaderWidth$
 0Q�6�   ��5   d   �� *Guards+   Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$ Username��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *
Username+6\     5#      $ Password��6-   $ * 6\    6?   �� *
Password+6\     5$      $
 Role��6-   $ * 6T    6;   �� *Role+6T   4  .System.Windows.Controls.DataGridTemplateColumn  5%      $ Action��61   $
 Auto 6A      CellTemplate 5&      �� 5'   "   .R�5(   &   ��  �� Orientation$ 
Horizontal=�61   .+�5)   *   �� -   5        $
��Edit��5)   1   
���   �
�������$��5q�6~   $��5q�6�   �� 5*   *   -   5        $��Delete��5*   1   
���   �
�������$��5q�6�   $��5q�6�   5+   '   5,   #   5.      50      51      �� 52      -   5        $��	Add Guard��52      $��40��6@   $��16(�6L   $
��Bold"�6Z   ���#28AEED
�������
�������$��2q�6�   $	��130��6�   53      �� 56   
   $��1��6   $��10q�6%   .+�57      �� $��Registered Vehicle List��6   $��20(�67   $
��Bold"�6E   $��0,0,0,10q�6W   �� 59      $
��Auto=�6   $��Disabled=�6>   $	��200��6g   .��5:        -   5        $ VehicleDataGrid��5:      $ False��64   $��0,0,0,10q�6P   ���#C9E2FF �#BDD7FD	 �#C9E2FF���#8DA9C4$��1q�5;   �   $
 0Q�6�    5<        5=      $ 
Vehicle ID��6-   $ * 6_    6A   �� *	VehicleID+6_     5>      $ Vehicle Name��6-   $ * 6c    6C   �� *VehicleName+6c     5?      $ 
Owner Name��6-   $ * 6_    6A   �� *	OwnerName+6_     5@      $ Vehicle Type��6-   $ * 6c    6C   �� *VehicleType+6c     5A      $ Action��61   $
 Auto 6A    5B      �� 5C   "   .R�5D   &   �� $ 
Horizontal=�61   .+�5E   *   �� -   5        $
��Edit��5E   1   
���   �
�������$��5q�6�   $��5q�6�   �� 5F   *   -   5        $��Delete��5F   1   
���   �
�������$��5q�6�   $��5q�6�   5G   '   5H   #   5J      5L      5M      �� 5N      -   5        $��Register Vehicle��5N      $��40��6N   $��16(�6Z   $
��Bold"�6h   ���#28AEED
�������
�������$��2q�6�   $	��154��6�   5O      �� 5R   
   -	   5        $��Generate Reports��5R      $	��Top=�6J   $��	0,354,0,0q�6b   $��2��6u   $��40��6�   $��16(�6�   $
��Bold"�6�   $��Center=�6�   ���#28AEED
�������
�������$��2q�6  $	��188��6"  5S      5T      