   M S B A M L   `   `   `  ����M  IStudent_Management, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Student_ManagementStudent_Management  5   	   %    Student_Management.All_Students   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Student_Management     5   	     � Title$  All_Students��5   	   $	��297��6   $
��1400��6+   .��5	      � .+�5
   
   �� -   5         ��Name$ label��5
      $��View Students��6   $	��Top=�67   $��34��6O   $
��1292��6[   $
��Bold"�6h   $��15(�6z   ���	#FFAAD352$��Center=�6�   $��Center=�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      $
��Left=�6%   $��	10,82,0,0q�6@   $	��Top=�6S   $	��147��6k   $
��1332��6x   �� 5   
   -   5        $ label1_Copy2��5      $	��Sex��6&   $
��Left=�64   $��
474,43,0,0q�6O   $	��Top=�6c   $��21��6{   $��33��6�   $��8(�6�   $
��Bold"�6�   ���	#FFB9DDEE6�   �� 5   
   -   5        $ label1_Copy3��5      $��Semester��6&   $
��Left=�69   $��
326,44,0,0q�6T   $	��Top=�6h   $��22��6�   $��70��6�   $��8(�6�   $
��Bold"�6�   ���	#FFB9DDEE6�   �� 5   
   -   5        $ label1_Copy4��5      $��Religion��6&   $
��Left=�69   $��
610,41,0,0q�6T   $	��Top=�6h   $��22��6�   $��44��6�   $��8(�6�   $
��Bold"�6�   ���	#FFB9DDEE J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 0.179Q�6&   T� 5      5      5      �� 5   
   -   5         ��Name$ comboBox_rl��5      $
��Left=�6(   $��
661,42,0,0q�6C   $	��Top=�6W   $	��106��6o    �� SelectedIndex$ 0��6{   .@�5      �� $	��ALL��6   �� 5      $��Hindu��6   �� 5      $��Muslim��6   �� 5      $��Buddhist��6   �� 5      $��	Christian��6   5      �� 5   
   -   5        $ label1_Copy9��5      $��
Department��6&   $
��Left=�6;   $��	16,44,0,0q�6V   $	��Top=�6i   $��22��6�   $��59��6�   $��8(�6�   $
��Bold"�6�   ���	#FFB9DDEE6�   �� 5    
   -   5        $ comboBox_dprtmnt��5       $
��Left=�6-   $��	80,44,0,0q�6H   $	��Top=�6[   $	��106��6s   $ 0��6   .@�5!      �� $	��ALL��6   �� 5"      $	��CSE��6   �� 5#      $	��EEE��6   �� 5$      $��CIVIL��6   �� 5%      $	��BBA��6   5&      �� 5'   
   -	   5        $ comboBox_semester��5'      $
��Left=�6.   $��
407,44,0,0q�6I   $	��Top=�6]   $��56��6u   $��20��6�   $ 0��6�   .@�5(      �� $	��ALL��6   �� 5)      $	��1_1��6   �� 5*      $	��1_2��6   �� 5+      $	��1_3��6   �� 5,      $	��2_1��6   �� 5-      $	��2_2��6   �� 5.      $	��2_3��6   �� 5/      $	��3_1��6   �� 50      $	��3_2��6   �� 51      $	��3_3��6   �� 52      $	��4_1��6   �� 53      $	��4_2��6   �� 54      $	��4_3��6   55      �� 56   
   -
   5        $ label1_Copy11��56      $��Section��6'   $
��Left=�69   $��
210,44,0,0q�6T   $	��Top=�6h   $��22��6�   $��42��6�   $��8(�6�   $
��Bold"�6�   ���	#FFB9DDEE6�   �� 57   
   -   5        $ comboBox_section��57      $
��Left=�6-   $��
264,44,0,0q�6H   $	��Top=�6\   $��51��6t   $��20��6   $ 0��6�   .@�58      �� $	��ALL��6   �� 59      $��A��6   �� 5:      $��B��6   �� 5;      $��C��6   �� 5<      $��D��6   5=      �� 5>   
   -   5        $ comboBox_Sex��5>      $
��Left=�6)   $��
518,42,0,0q�6D   $	��Top=�6X   $��82��6p   $ 0��6{   .@�5?      �� $	��ALL��6   �� 5@      $
��Male��6   �� 5A      $��Female��6   �� 5B      $��Other��6   5C      �� 5D   
   -   5         ��Name$ button��5D      $
��Show��6!   $
��Left=�60   $��1267,47,0,0q�6K   $	��Top=�6`   $��75��6x   ���	#FF0CC6CF6�   �� 5E   
   -   5        $ label1_Copy16��5E      $��
Vaccinated��6'   $
��Left=�6<   $��
786,43,0,0q�6W   $	��Top=�6k   $��21��6�   $��62��6�   $��8(�6�   $
��Bold"�6�   ���	#FFB9DDEE6�   �� 5F   
   -   5        $ comboBox_Vaccinated��5F      $
��Left=�60   $��
864,44,0,0q�6K   $	��Top=�6_   $��63��6w   $ 0��6�   .@�5G      �� $	��ALL��6   �� 5H      $	��Yes��6   �� 5I      $��No��6   5J      �� 5K   
   -   5        $ label1_Copy17��5K      $��Blood Donate��6'   $
��Left=�6>   $��1103,46,0,0q�6Y   $	��Top=�6n   $��25��6�   $��64��6�   $��8(�6�   $
��Bold"�6�   ���	#FFB9DDEE6�   �� 5L   
   -   5        $ comboBox_Blood_Donate��5L      $
��Left=�62   $��1181,46,0,0q�6M   $	��Top=�6b   $��70��6z   $��21��6�   $ 0��6�   .@�5M      �� $	��ALL��6   �� 5N      $	��Yes��6   �� 5O      $��No��6   5P      �� 5Q   
   -   5        $ label1_Copy18��5Q      $��Blood Group��6'   $
��Left=�6=   $��
948,44,0,0q�6X   $	��Top=�6l   $��22��6�   $��72��6�   $��8(�6�   $
��Bold"�6�   ���	#FFB9DDEE6�   �� 5R   
   -   5        $ comboBox_BloodGroup��5R      $
��Left=�60   $��1035,46,0,0q�6K   $	��Top=�6`   $��51��6x   $��20��6�   $ 0��6�   .@�5S      �� $	��ALL��6   �� 5T      $��A+��6   �� 5U      $��A-��6   �� 5V      $��B+��6   �� 5W      $��B-��6   �� 5X      $	��AB+��6   �� 5Y      $	��AB-��6   �� 5Z      $��O+��6   �� 5[      $��O-��6   5\      �� 5]   
   -   5        $ button_Copy1��5]      $
��Back��6'   $
��Left=�66   $��
16,236,0,0q�6Q   $	��Top=�6e   $��75��6}   ���	#FFBC6FD86�   �� 5^   
   -   5         ��Name$ for_id��5^      $
��Left=�6$   $��1089,266,0,-18q�6?   $
��Wrap=�6W   $	��Top=�6k   $	��115��6�   ���	#FFF6F7F7$��18��6�   $ 1.269,2.737&�6�   $��18(�6�   $
��Bold"�6�   ���	#FFF7F3F36�   �� 5_   
   -   5        $ for_name��5_      $
��Left=�6&   $��1047,242,0,0q�6A   $
��Wrap=�6W   $	��Top=�6k   $	��157��6�   $ 1.462,-0.459&�6�   $��24��6�   $
��Bold"�6�   $��Monotype Corsiva)�6�   $��20(�6�   ���	#FFF4F9F8���	#FFF3F2F26  5a      5b      