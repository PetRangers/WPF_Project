   M S B A M L   `   `   `  ����?  ;View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ViewView  5          View.PetUserControl1   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $localclr-namespace:View     5      $	��730��5      $
��1400��6,   .��5      (� .��5	   
   �   � ColumnDefinitions  5
      �� 5      $	��41* �6#   �� 5      $
��199* �6#   .+�5      �� -   5         ��Name$ SearchButton��5      $��查詢所有��6+   $
��Left=�6:   $	��105��6U   $��	10,35,0,0q�6b   $	��Top=�6u   $	��272��6�   $��14(�6�   �� 5      -   5        $ SearchButton_Copy��5      $��新增��60   $
��Left=�6=   $	��105��6X   $��
10,199,0,0q�6e   $	��Top=�6y   $	��272��6�   $��14(�6�   �� 5      -   5        $ SearchButton_Copy1��5      $��查詢��61   $
��Left=�6>   $	��105��6Y   $��	0,384,0,0q�6f   $	��Top=�6y   $	��272��6�   $��14(�6�   �� 5      -   5        $ SearchButton_Copy2��5      $��修改��61   $
��Left=�6>   $	��105��6Y   $��	0,534,0,0q�6f   $	��Top=�6y   $	��272��6�   $��14(�6�   �� 5      -   5        $ SearchButton_Copy3��5      $��刪除��61   $
��Left=�6>   $	��105��6Y   $��
10,691,0,0q�6f   $	��Top=�6z   $	��272��6�   $��14(�6�   �� 5      -   5        $ SearchButton_Copy4��5      $��清除��61   $
��Left=�6>   $	��105��6Y   $��	0,854,0,0q�6f   $	��Top=�6y   $	��272��6�   $��14(�6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ dataGrid��5      $��1��6)   $
��Left=�69   $��
478,10,0,0q�6T   $	��Top=�6h   $
��1000��6�   $
��1004��6�   $��14(�6�   �� 5      -   5         ��Name$ label��5      $��HospitalName：��6#   $
��Left=�6;   $��
10,338,0,0q�6V   $	��Top=�6j    J� RenderTransformOrigin$ 0.55,-0.846&�6�   $��29��6�   $	��162��6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   $��14(�6�   $��1��6�   �� 5      -	   5        $ 
label_Copy��5      $��HospitalAddress：��6(   $
��Left=�6C   $��
10,370,0,0q�6^   $	��Top=�6r   $ 0.55,-0.846&�6�   $��29��6�   $	��162��6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   $��14(�6�   $��1��6  �� 5      -
   5        $ label_Copy1��5      $��AddressArea：��6)   $
��Left=�6@   $��
10,403,0,0q�6[   $	��Top=�6o   $ 0.55,-0.846&�6�   $��29��6�   $	��162��6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   $��14(�6�   $��1��6  �� 5      -   5        $ label_Copy2��5      $��HospitalPhone：��6)   $
��Left=�6B   $��
10,433,0,0q�6]   $	��Top=�6q   $ 0.55,-0.846&�6�   $��29��6�   $	��162��6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   $��14(�6�   $��1��6  �� 5      -   5        $ label_Copy3��5      $��
PetRace：��6)   $
��Left=�6<   $��
10,461,0,0q�6W   $	��Top=�6k   $ 0.55,-0.846&�6�   $��29��6�   $	��162��6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   $��14(�6�   $��1��6�   �� 5      -   5        $ label_Copy4��5      $��BusinessHours：��6)   $
��Left=�6B   $��
10,493,0,0q�6]   $	��Top=�6q   $ 0.55,-0.846&�6�   $��29��6�   $	��162��6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   $��14(�6�   $��1��6  �� 5      -   5        $ label_Copy5��5      $��Emergency：��6)   $
��Left=�6>   $��
10,532,0,0q�6Y   $	��Top=�6m   $ 0.55,-0.846&�6�   $��29��6�   $	��162��6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   $��14(�6�   $��1��6  �� 5      -   5        $ label_Copy6��5      $��OutpatientProject：��6)   $
��Left=�6F   $��
10,560,0,0q�6a   $	��Top=�6u   $ 0.55,-0.846&�6�   $��29��6�   $	��162��6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   $��14(�6�   $��1��6	  �� 5      -   5        $ label_Copy7��5      $��Equipment：��6)   $
��Left=�6>   $��
10,588,0,0q�6Y   $	��Top=�6m   $ 0.55,-0.846&�6�   $��29��6�   $	��162��6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   $��14(�6�   $��1��6  �� 5      -   5        $ label_Copy8��5      $��WebAddress：��6)   $
��Left=�6?   $��
10,634,0,0q�6Z   $	��Top=�6n   $ 0.55,-0.846&�6�   $��29��6�   $	��162��6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   $��14(�6�   $��1��6  �� 5      -   5         ��Name$ textBox��5      $��1��6(   $
��Left=�68   $��23��6S   $��150,338,0,0q�6_    �� TextWrapping$
 Wrap=�6t   $	��Top=�6�   $	��282��6�   $��16(�6�   $
��Bold"�6�   
���   ���6�   Z� 6�   �� 5       -   5        $ textBox_Copy��5       $��1��6,   $
��Left=�6<   $��23��6W   $��150,372,0,0q�6c   $
 Wrap=�6x   $	��Top=�6�   $	��282��6�   $��16(�6�   $
��Bold"�6�   
���   ���6�   Z� 6�   �� 5!      -   5        $ textBox_Copy1��5!      $��1��6-   $
��Left=�6=   $��23��6X   $��150,405,0,0q�6d   $
 Wrap=�6y   $	��Top=�6�   $	��282��6�   $��16(�6�   $
��Bold"�6�   
���   ���6�   Z� 6�   �� 5"      -   5        $ textBox_Copy2��5"      $��1��6-   $
��Left=�6=   $��23��6X   $��150,435,0,0q�6d   $
 Wrap=�6y   $	��Top=�6�   $	��282��6�   $��16(�6�   $
��Bold"�6�   
���   ���6�   Z� 6�   �� 5#      -   5        $ textBox_Copy3��5#      $��1��6-   $
��Left=�6=   $��23��6X   $��150,463,0,0q�6d   $
 Wrap=�6y   $	��Top=�6�   $	��282��6�   $��16(�6�   $
��Bold"�6�   
���   ���6�   Z� 6�   �� 5$      -   5        $ textBox_Copy4��5$      $��1��6-   $
��Left=�6=   $��23��6X   $��150,493,0,0q�6d   $
 Wrap=�6y   $	��Top=�6�   $	��282��6�   $��16(�6�   $
��Bold"�6�   
���   ���6�   Z� 6�   �� 5%      -   5        $ textBox_Copy5��5%      $��1��6-   $
��Left=�6=   $��23��6X   $��150,534,0,0q�6d   $
 Wrap=�6y   $	��Top=�6�   $	��282��6�   $��16(�6�   $
��Bold"�6�   
���   ���6�   Z� 6�   �� 5&      -   5        $ textBox_Copy6��5&      $��1��6-   $
��Left=�6=   $��23��6X   $��150,562,0,0q�6d   $
 Wrap=�6y   $	��Top=�6�   $	��282��6�   $��16(�6�   $
��Bold"�6�   
���   ���6�   Z� 6�   �� 5'      -   5        $ textBox_Copy7��5'      $��1��6-   $
��Left=�6=   $��23��6X   $��150,590,0,0q�6d   $
 Wrap=�6y   $	��Top=�6�   $	��282��6�   $��16(�6�   $
��Bold"�6�   
���   ���6�   Z� 6�   �� 5(      -   5        $ textBox_Copy8��5(      $��1��6-   $
��Left=�6=   $��23��6X   $��150,636,0,0q�6d   $
 Wrap=�6y   $	��Top=�6�   $	��282��6�   $��16(�6�   $
��Bold"�6�   
���   ���6�   Z� 6�   �� 5)      -   5        $ label_Copy9��5)      $��OnlineConsultation：��6)   $
��Left=�6G   $��
10,662,0,0q�6b   $	��Top=�6v   $��29��6�   $	��120��6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   $��14(�6�   $��1��6�   �� 5*      -   5        $ textBox_Copy9��5*      $��1��6.   $
��Left=�6>   $��23��6Y   $��150,668,0,0q�6e   $
 Wrap=�6z   $	��Top=�6�   $	��282��6�   $��16(�6�   $
��Bold"�6�   
���   ���6�   Z� 6�   �� 5+      -   5        $ label1��5+      $��HospitaNumber：��6$   $
��Left=�6=   $��
10,313,0,0q�6X   $	��Top=�6l   $��25��6�   $	��152��6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   $��14(�6�   $��1��6�   �� 5,      -   5        $ label2��5,      $��Number��6$   $��1��65   $
��Left=�6E   $��150,313,0,0q�6`   $	��Top=�6u   $��25��6�   $��91��6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   $��14(�6�   �� 5-      -    5         ��Name$ ComHospitalName��5-      $
��Left=�60   $��	35,61,0,0q�6K   $	��Top=�6^   $	��120��6v   $��31��6�   $��1��6�   $��14(�6  ��6�   Z� 6  �� 5.      -!   5        $ ComAddressArea��5.   F   $��1��6^   $
��Left=�6n   $��
198,61,0,0q�6�   $	��Top=�6�   $	��120��6�   $��31��6�   $��14(�6�   �� 5/      -"   5        $ 
ComPetRace��5/   B   $��1��6V   $
��Left=�6f   $��374,0,0,918q�6�   $��Bottom=�6�   $	��120��6�   $��31��6�   $ 0.467,-1.667&�6�   $��14(�6�   51      53      54      55      