   M S B A M L   `   `   `  ����L  HMegaSuperBombaApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MegaSuperBombaAppMegaSuperBombaApp  5   	   "    MegaSuperBombaApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:MegaSuperBombaApp     5   	   -   5          � WindowStyle$
  None=�5       � 
ResizeMode$ NoResize=�5	   	   
���   �$��0q�5   	   ���#282828 � Title$ SuperMegaBombaApp��5   	   $	��500��6#   $��839.071��60   .��5      �  � RowDefinitions 5   
   �� 5      $��35 �6   �� 5      $	��58* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $	��20* �6#   �� 5      $��40 �6#   �� 5      $��40 �6#   �� 5      $��40 �6#   .+�5      �� -   5        $��btnMinimize��5    *   
���  ��$��1��5   '   
�������$��2q�5       $
��Left=�5!   /   $��40��6J   5#      �� 5%      -   5        $��btnfullScreen��5&   )   
���  ��$��2��5%   '   
����  �$��2q�5&      5)      �� 5+      -   5        $��btnClose��5,      $��3��5+      
���  ��$��0q�5-      5/      52       � 54   
   -   5          �Name$ 	MainFrame��54   ;     � NavigationUIVisibility$ Hidden=�6   $��1q�60   $��2��6N   56      59      