   M S B A M L   `   `   `  ����C  ?Project1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Project_one_EADProject_one_EAD  5          Project_one_EAD.Add_Gurd   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Project_one_EAD     5        N� Title$  	Add_Guard��5	      .��5      � ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ #E8F0FF��6    � Offset$ 0Q�6/   � 5      $ #D3E1FF��6   $
 0.75Q�6/   � 5      $ #A3C1FF��6   $ 1Q�6/   5      .+�5   
   �� 
�������$��2q�6%    �� CornerRadius$ 12��69    �� Padding$ 20q�6K   $��150,50,150,50q�6X   ._�5      �� $��Center=�6   $��Center=�66   .+�5      �� $��	Add Guard��6   $��24(�6-   $
��Bold"�6;   $��Center=�6M   $��0,0,0,20q�6j   
���   �6|   �� 5       �� Orientation$ 
Horizontal=�6   $��0,0,0,10q�66   .+�5      �� $��Username��6    $
��Bold"�60   $��18(�6B   $��Center=�6P   
���   �$��20,20,40,30q�6~   �� 5      -   5         ��Name$ username��5      $	��200��60   $��30��6<   $��10,0,0,0q�6H   ���#DADADA
���   �$��0,0,0,2q�6�   5      �� 5      $ 
Horizontal=�6   $��0,0,0,10q�66   .+�5      �� $��Password��6    $
��Bold"�60   $��18(�6B   $��Center=�6P   
���   �$��20,20,40,30q�6~   G� 5       -   5        	 G�Name$	 password��5    "   $	��200��64   $��30��6@   $��10,0,0,0q�6L   ���#DADADA
���   �$��0,0,0,2q�6�   5!      �� 5#      $��Submit��6   $	��100��6*   $��40��66   $��16(�6B   $
��Bold"�6P   $��Center=�6b   ���#28AEED
�������
�������$��2q�6�   �� 5%      -   5        
 ��Name$
 
lblMessage��5%      
���  ��$
��Bold"�6A   $��0,10,0,0q�6S   $��Center=�6e   $��14(�6�   $��
Montserrat)�6�   5&      5'      �� 5*   
   
������  K� ZIndex$
 1000��6*   ��5+      �� 5,       �� 
TargetType" ��6   .�5-      ��  �� Property � y� �� Value$ 	Collapsed=�63    �� Triggers 5.      �� 5/       �� Binding 6&   �� *	IsLoading+ �� Value True6D   .a�50      ��  � y�$ Visible=�6;   51      53      ._�55      � ���	#8000000057      58      59      5:      