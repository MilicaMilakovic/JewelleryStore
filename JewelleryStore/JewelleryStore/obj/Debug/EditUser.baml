   M S B A M L   `   `   `  ����I  EJewelleryStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:JewelleryStoreJewelleryStore  5   	       JewelleryStore.EditUser   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   (localclr-namespace:JewelleryStore  5   	     � Title$  EditUser��5	   	   $	��470��6   $	��400��6'    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   .��5      �� ���#80CBC4$��2q�6#   ._�5   
   �  � RowDefinitions 5      �� 5      $	��47* �6    �� 5      $	��50* �6    �� 5      $	��50* �6    �� 5      $	��50* �6    �� 5      $	��50* �6    �� 5      $
��122* �6    �� 5      $	��82* �6    .+�5      �� -   5         ��Name$ 	userLabel��5      $
��User��6'   $��15(�66   $��10,0,0,0q�6D   $
��Bold"�6V   ���#80CBC46h   �� 5      -   5         ��Name$ 	nameField��5      $��1��6)   $	��350��66   $��40��6B    %  !MaterialDesignFloatingHintTextBox#��[  5       )  #MaterialDesignThemes.Wpf.HintAssist   Hint# � ��5!      $
��Left=�5"      $	��Top=�6-   $��20,0,0,0q�6E   �� 5$      -   5        $ lastnameField��5$      $��1��6-   $	��350��6:   $��40��6F   #��[  5%        Lastname# �  5&      $
��Left=�5'      $��Bottom=�6/   $��	20,0,0,20q�6J   $��2��6]   �� 5)      -   5        $ usernameField��5)      $��3��6-   $	��350��6:   $��40��6F   #��[  5*        Username# �  5+      $
��Left=�5,      $	��Top=�6/   $��20,0,0,0q�6G   �� 5.      -   5        $ passwordField��5.      $��4��6.   $	��350��6;   $��40��6H   #��[  5/        Password# �  50      $
��Left=�51      $��Bottom=�6/   $��	20,0,0,20q�6J   �� 53      -   5        $ salaryField��53      $��5��6,   $	��350��69   $��40��54      #��[  55        Pay# �  56      $
��Left=�57      $	��Top=�6/   $��20,0,0,0q�6G   (  "System.Windows.Controls.DatePicker  58      -   5          Name$ 	dateSince��58       	 Since# �  59       $  MaterialDesignOutlinedDatePicker#��[ 5:      $��20,57,240,9q�6I   $��5��6^   $��56��6k   �� 5<      -   5        	 ��Name$	 EditBtn��5<       % !MaterialDesignOutlinedLightButton#��[ 5=        Edit#���  5>      $��90,15,92,27q�6,   $��6��6A   $��40��6N   �� 5A      -	   5        $	 AddBtn��5A      $y�	Collapsed=�65   #��[ 5B       	 Add#��� 	 5C      $��90,15,92,27q�6+   $��6��6@   $��40��6M   	� 5F      -
   5        
 	�Name$
 adminCheckBox��5F   '   $��5��6    5
 1MaterialDesignChoiceChipPrimaryOutlineRadioButton#��[
 5G       d� 	IsChecked$ FalseY�5H      $��Admin��5I      $��
244,63,0,0q�6   $��88��6/   $��43��6:   $	��Top=�6F   �� 5J      -   5         ! MaterialDesignFlatLightButton#��[ 5K      $��
339,0,0,10q�5L      $
��Auto��6   .��5M      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6*   5N      5O      5P      5Q      