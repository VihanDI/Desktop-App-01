   M S B A M L   `   `   `  ����I  EDesktop_App_01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Desktop_App_01.ViewsDesktop_App_01.Views  5   	   E'clr-namespace:Desktop_App_01.ViewModelsDesktop_App_01.ViewModels  5   	   )    #Desktop_App_01.Views.ViewDataWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Desktop_App_01.Views     5   	   @viewModelDir'clr-namespace:Desktop_App_01.ViewModels     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	     � Title$  EditStudentWindow��5
   	   $	��520��6#   $	��800��60    � Icon$ /Icons/Icon.png��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$ SingleBorderWindow=�5   	    � 
ResizeMode$ CanMinimize=�5   	    � DataContext 5      0   *Desktop_App_01.ViewModels.ViewDataWindowVM  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��0.25* �6   �� 5      $
��1.5* �6   .+�5   
   ��  �� CornerRadius$ 	15 0 0 15��6   $��0��6*   ��5      �� 5       �� Color$ #ffffff��6"   5      ._�5      � .+�5       �� 	 �� Orientation$	 Vertical=�6   .+�5!      �� $	 
Horizontal=�6!   .+�5"      �� -   5           circleButton#��[  5"   !   .��5#      .  (MahApps.Metro.IconPacks.PackIconMaterial  
   Kind$
 	ArrowLeft=�64   5$      �� 5%        	titleText#��[ 6$    �� TextAlignment$
 Left=�6G   $
��0 15q�6\   $��View student details��6j   5&      5'      5(      5)      �� 5+   
   $ 	0 15 15 0��6   ���#f6f6f6$��1��6?   ._�5,      �� $	 Vertical=�6   $��20q�60   .+�5-      �� $	 
Horizontal=�6   .+�5.      ��   dataEntryText#��[ 6    $��
First Name��6G   �� 5/      #��[ 6;   ��6    �� *	FirstName+6;   50      �� 52      $	 
Horizontal=�6   .+�53      �� #��[ 6    $��	Last Name��6G   �� 54      #��[ 6:   ��6    �� *
LastName+6:   55      �� 57      $	 
Horizontal=�6   .+�58      �� #��[ 6    $	��Age��6G   �� 59      #��[ 65   ��6    �� *Age+65   5:      �� 5<      $	 
Horizontal=�6   .+�5=      �� #��[ 6    $��Date of Birth��6G   �� 5>      #��[ 6=   $	��150��6d   ��6    �� *DateOfBirth+6d   5?      �� 5A      $	 
Horizontal=�6   .+�5B      �� #��[ 6    $	��GPA��6G   �� 5C      #��[ 66   $	��150��6]   ��6!   �� *GPA+6]   5D      5E      5F      5G      5H      