   M S B A M L   `   `   `  ����C  ?Project1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Project_one_EADProject_one_EAD  5          Project_one_EAD.guardpage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Project_one_EAD     5        N� Title$  	guardpage��5	      .��5      � .+�5   
   �� $��IN OUT TIMING��6   $��Center=�6)   $	��Top=�6F   $��24(�6^   $
��Bold"�6l   ���#E8F0FF
����·�$��0,20,0,0q�6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��mygrid��5         AutoGenerateColumns$ False��6!   $��0,80,0,0q�6=   ���#E8F0FF
����·�$��1q�6z    � 	Resources 5       �� 
TargetType �� Property �� Value��%T   '��       �� 5      " ��6   .�5      ��  � ��
 ��·�63   5      5         ColumnHeaderStyle 5      �� 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5      ��  � ��
 ��·�63   �� 5       � ��
 �����63   �� 5       � ��$ 16(�61   �� 5       � ��$
 Bold"�63   �� 5       � ��$ Center=�6C   �� 5       � ��$ 10q�60   �� 5       � ��
 �����64   �� 5        � ��$ 0,0,1,1q�68   5!         Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%   	   Header$	 Entry ID��6/   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6A   �� *	CheckInID+  5&      $ * 6%   $	 
Vehicle ID��6/   
 6C   �� *	VehicleID+  5'      $ * 6%   $	 Entry Date Time��6/   
 6H   �� *CheckInTime+  5(      $ * 6%   $	 Exit Date Time��6/   
 6G   �� *CheckOutTime+5*      � 5-   
   -   5         �Name$ Mygrid��5-      $��	0,250,0,0q�6   ���#E8F0FF$��Bottom=�6G    � ColumnDefinitions 5.      �� 5/      $��* �6#   �� 50      $
��Auto �6#   �� 51      $
��Auto �6#   .+�55      �� $��Vehicle No Plate��6   $
��Bold"�6/   $
��Left=�6B   $	��Top=�6]   $��28��6u   $	��138��6�   �� 56      -   5         ��Name$ cmbVehicleNoPlate��56      $
��Left=�62   $	��Top=�6M   $	��120��6e   
�������$��110,0q�6�   �� 59      -   5        $��1��59      $��In��6%   $��Right=�6F   $	��Top=�6b   $��60��6z   ���#4CAF50
�������$
��10,0q�6�   �� 5:      -   5        $��2��5:      $	��Out��6%   $��Right=�6H   $	��Top=�6d   $��60��6|   ���#F44336
�������$
��10,0q�6�   5;      5<      5=      