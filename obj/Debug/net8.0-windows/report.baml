   M S B A M L   `   `   `  ����C  ?Project1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:p2p2  5          	p2.report   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      "localclr-namespace:p2     5        N� Title$  report��5	      .��5      �  J� RenderTransformOrigin$ 0.496,0.712&�6   ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ #E8F0FF��6    � Offset$ 0Q�6/   � 5      $ #D3E1FF��6   $
 0.75Q�6/   � 5      $ #A3C1FF��6   $ 1Q�6/   5      .+�5   
   �� $��Report Generate��6   $��Center=�6+   $	��Top=�6H   $��24(�6`   $
��Bold"�6n   
���   �6�   � 5   
   -   5         �Name$ Mygrid��5      $��0,334,0,-39q�6   ���#A3C1FF.+�5      �� $��End Date��6   $
��Bold"�6'   $
��Left=�69   $��	10,60,0,0q�6T   $	��Top=�6g   $��28��6   $��72��6�   $ 0.132,-0.946&�6�   �� 5      $��
Start Date��6   $
��Bold"�6)   $
��Left=�6;   $��	10,10,0,0q�6V   $	��Top=�6i   $��28��6�   $��88��6�   $ 	3.064,0.5&�6�   �� 5       �� Orientation$ 
Horizontal=�6   $��10q�62   .+�5      (  "System.Windows.Controls.DatePicker  -   5          Name$ startDatePicker��5      $	��150��66   $ 
0.5,-0.922&�6e   $��31��6�   $��90,-90,80,-19q�6�   	   SelectedDate	 6B   �� *	StartDate+6�   �� 5      -   5        $��Filter��5      $ 0.516,-0.891&�6L   $��40��6�   $��16(�6�   $
��Bold"�6�   ���#28AEED
�������
�������$��2q�6�   $	��145��6  ��6*   �� *FilterCommand+6    5       -   5        $ endDatePicker��5       $	��150��64   $��30��6a   $��Bottom=�6m   $��-520,10,80,30q�6�   	 6@   �� *	EndDate+6�   �� 5!      -   5        $��Generate Report��5!      $��40��6V   $��16(�6b   $
��Bold"�6p   ���#28AEED
�������
�������$��2q�6�   $	��206��6�   $��
75,-0,0,10q�6�   5"      5#      &   System.Windows.Controls.DataGrid  5$   
   -   5        $��mygrid��5$      
   AutoGenerateColumns$
 False��6!   $��
0,37,0,119q�6=   $ 0.5,0.5&�6Q   z�5%      V� 5&      .~�5'      �� �� 5(       �� AngleX$ 0.239Q�6$   �� 5)      T� 5*       T� X$ 0.496Q�6)   5+         Columns 5-      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      Header$ Entry ID��6/   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *	CheckInID+  51      $ * 6%   $ 
Vehicle ID��6/    6C   �� *	VehicleID+  52      $ * 6%   $ Entry Date Time��6/    6H   �� *CheckInTime+  53      $ * 6%   $ Exit Date Time��6/    6G   �� *CheckOutTime+   ColumnHeaderStyle 55      �� 56       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�57      ��  �� Property � �� �� Value �#A3C1FF63   �� 58       � ��
 �����63   �� 59       � ��$ 19(�61   �� 5;       � ��$
 Bold"�63   5>      5@      5D      5E      