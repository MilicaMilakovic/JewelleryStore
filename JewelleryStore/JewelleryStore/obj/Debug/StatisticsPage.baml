   M S B A M L   `   `   `  ����U  QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf  5      I EJewelleryStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:JewelleryStoreJewelleryStore 5      #   JewelleryStore.StatisticsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      (localclr-namespace:JewelleryStore  5        N� Title$  StatisticsPage��5       � 	Resources 5       �� Source�� 5   
   $ /Resources/Styles.xaml?�6   %    .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��41* �6   �� 5      $
��149* �6    � ColumnDefinitions 5   
   �� 5      $
��443* �6   �� 5      $
��292* �6   .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��0��6      PrimaryHueLightBrush#���   5       ! PrimaryHueDarkForegroundBrush#���  5      $��8q�5          UniformCornerRadius$ 6Q�5!      $��52,16,227,10q�6'   .��5"      �� $
��Wrap=�5#      $
��Bold"�5$       
 Profit#���  5%      $��0,0,0,19q�61   5'        5*   
   $��0��6   #���   5+      #���  5,      $��8q�5-      $ 6Q�5/      $��252,16,28,10q�6'   .��51      �� $
��Wrap=�52      $
��Bold"�53        	ItemsSold#���  54      $��0,0,-6,0q�64   58      �� 5:   
   -   5         ��Name$ profitLabel��5:      
�������$��Center=�68   $��15(�6\   $
��Bold"�6j   $��30��6|   $��52,42,227,10q�6�   �� 5;   
   -   5        $ 
itemsLabel��5;      
�������$��Center=�67   $
��Bold"�6[   $��15(�6m   $��30��6{   $��252,42,28,10q�6�      LiveCharts.Wpf.PieChart  5=   
   -   5        $��1��5=      &    LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$ Bottom=�6H      	Hoverable . $��
10,22,0,10q�6�   	   Series	 6$   �� *SeriesCollection+
   ChartLegend
 5>      "   LiveCharts.Wpf.DefaultLegend  5?         
BulletSize$ 15Q�6$      DataTooltip 5A      #   LiveCharts.Wpf.DefaultTooltip  5B         
BulletSize$ 20Q�6%   5D        5H   
   $��1��5I      $��2��5J      $��10q�5K       ! MaterialDesignLightBackground#���  5L      +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�5M         ShadowEdges$	 All=�5N      .��5Q      �� -   5         ��Name$ billsSV��5Q      $��Visible=�6,   $��1��6R   $��2��6b   $��0��6s   $
��Auto��6�   $	��Top=�6�   $
��Left=�6�   $	��270��6�   $��0,65,0,0q�6�   .��5R      �� -   5         ��Name$ Bills��5R   4    �� Orientation$ Vertical=�6   5U      5V      5W      �� 5[   
    	 Bills#���  6   $
��Bold"�62   #���   6D   $��1��6x   $��119,10,107,48q�6�   '  !MaterialDesignThemes.Wpf.PackIcon  5\   
   $��20��6"   $��20��6-      Kind$ 
Identifier=�69   #���   6K   $��	10,39,0,0q�6   $��1��6�   6�     5]   
   $��20��6#   $��20��6.   $ ClockTimeThreeOutline=�6:   #���   6W   $��	87,39,0,0q�6�   $��1��6�     5^   
   $��20��6#   $��20��6.   $ CurrencyUsd=�6;   #���   6N   $��
174,39,0,0q�6�   $��1��6�   6�     5_   
   $��20��6$   $��20��6/   $
 User=�6;   #���   6G   $��
230,39,0,0q�6{   $	��Top=�6�   $��1��6�   6�   5c      5d      