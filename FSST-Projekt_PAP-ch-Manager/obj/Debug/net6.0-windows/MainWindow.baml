   M S B A M L   `   `   `  ����V  RFSST-Projekt_PAP-ch-Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:FSST_Projekt_PAP_ch_ManagerFSST_Projekt_PAP_ch_Manager  5   	   ,    &FSST_Projekt_PAP_ch_Manager.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:FSST_Projekt_PAP_ch_Manager     5   	   -   5          � Title$  
MainWindow��5   	   $	��520��6   $	��960��6)   .��5	      � .+�5
   
   �� $
��Left=�6   $��55��6+   $��
500,10,0,0q�67   $	��Top=�6K   $	��286��6c   $��/Bild_Deko.png��6o   �� 5   
   $
��Left=�6   $��55��6+   $��	10,10,0,0q�67   $	��Top=�6J   $	��286��6b   $��/Bild_Deko.png��6n   �� 5   
   $
��Left=�6   $	��484��6/   $��	791,0,0,0q�6<   
���   �$��Center=�6^   $	��159��6y   �� 5   
   $��
Funktionen��6   $
��Left=�6%   $��25��6@   $��
803,24,0,0q�6L   $	��Top=�6`   $	��136��6x   �� 5   
   $��Figur:��6   $
��Left=�6!   $��25��6<   $��
301,10,0,0q�6H   $	��Top=�6\   $��73��6t   �� 5   
   $��Spieler:��6   $
��Left=�6#   $��25��6>   $��
301,40,0,0q�6J   $	��Top=�6^   $��73��6v   �� 5   
   -   5         ��Name$ LBL_charname��5      $��CharakterName��6&   $
��Left=�6>   $��25��6Y   $��
374,10,0,0q�6e   $	��Top=�6y   $	��121��6�   �� 5   
   -   5        $ 
LBL_Player��5      $��
PlayerName��6$   $
��Left=�69   $��25��6T   $��
374,40,0,0q�6`   $	��Top=�6t   $	��121��6�   �� 5   
   $	��Typ��6   $
��Left=�6   $��25��69   $��	10,70,0,0q�6E   $	��Top=�6X   $��31��6p   �� 5   
   -   5        $ 	LBL_beruf��5      $��CharakterBeruf��6#   $
��Left=�6<   $��25��6W   $��	54,70,0,0q�6c   $	��Top=�6v   $��99��6�   �� 5   
   $
��Grad��6   $
��Left=�6   $��25��6:   $��
153,70,0,0q�6F   $	��Top=�6Z   $��37��6r   �� 5   
   -   5        $ LBL_Grad��5      $��CharakterGrad��6"   $
��Left=�6:   $��25��6U   $��
195,70,0,0q�6a   $	��Top=�6u   $	��101��6�   �� 5   
   $��Spezialisierung��6   $
��Left=�6*   $��25��6E   $��
10,100,0,0q�6Q   $	��Top=�6e   $��94��6}   �� 5   
   -   5        $ LBL_SPEZIAL��5      $��CharakterSpezialisierung��6%   $
��Left=�6H   $��25��6c   $��109,100,0,0q�6o   $	��Top=�6�   $	��170��6�   �� 5   
   $
��Left=�6   $	��296��6/   $��
284,70,0,0q�6<   
���   �$	��Top=�6_   $	��196��6w   �� 5   
   $��Geburtsdatum��6   $
��Left=�6'   $��30��6B   $��
296,82,0,0q�6N   $	��Top=�6b   $��88��6z   �� 5   
   -   5        $ LBL_BIRTHDAY��5      $��BIRTHDAY��6&   $
��Left=�69   $��30��6T   $��
389,82,0,0q�6`   $	��Top=�6t   $��82��6�   �� 5   
   $��Alter��6   $
��Left=�6    $��25��6;   $��296,117,0,0q�6G   $	��Top=�6\   $��39��6t   �� 5   
   -   5        $ LBL_AGE��5      $	��AGE��6!   $
��Left=�6/   $��25��6J   $��338,118,0,0q�6V   $	��Top=�6k   $��38��6�   �� 5   
   -	   5        $ LBL_HAND��5      $
��HAND��6"   $
��Left=�61   $��26��6L   $��376,118,0,0q�6X   $	��Top=�6m   $��44��6�   �� 5   
   $��händig��6   $
��Left=�6!   $��26��6<   $��425,118,0,0q�6H   $	��Top=�6]   $��46��6u   �� 5   
   $��Größe��6   $
��Left=�6    $��25��6;   $��296,147,0,0q�6G   $	��Top=�6\   $��44��6t   �� 5    
   -
   5        $ LBL_GROESSE��5       $��CharakterGroesse��6%   $
��Left=�6@   $��25��6[   $��354,147,0,0q�6g   $	��Top=�6|   $	��117��6�   �� 5!   
   $��Gestalt��6   $
��Left=�6"   $��25��6=   $��296,177,0,0q�6I   $	��Top=�6^   $��49��6v   �� 5"   
   -   5        $ LBL_Gestalt��5"      $��GESTALT��6%   $
��Left=�67   $��25��6R   $��357,177,0,0q�6^   $	��Top=�6s   $	��114��6�   �� 5#   
   $��Gewicht��6   $
��Left=�6"   $��25��6=   $��296,202,0,0q�6I   $	��Top=�6^   $��53��6v   �� 5$   
   -   5        $ LBL_Gewicht��5$      $��GEWICHT��6%   $
��Left=�67   $��25��6R   $��357,202,0,0q�6^   $	��Top=�6s   $	��114��6�   �� 5%   
   $��Stand��6   $
��Left=�6    $��25��6;   $��296,227,0,0q�6G   $	��Top=�6\   $��48��6t   �� 5&   
   -   5        $ 	LBL_stand��5&      $��STAND��6#   $
��Left=�63   $��25��6N   $��357,227,0,0q�6Z   $	��Top=�6o   $	��114��6�   �� 5'   
   $��Heimat��6   $
��Left=�6!   $��25��6<   $��296,254,0,0q�6H   $	��Top=�6]   $��48��6u   �� 5(   
   -   5        $ 
LBL_heimat��5(      $��HEIMAT��6$   $
��Left=�65   $��25��6P   $��357,254,0,0q�6\   $	��Top=�6q   $	��114��6�   �� 5)   
   $��Glaube��6   $
��Left=�6!   $��25��6<   $��296,279,0,0q�6H   $	��Top=�6]   $��56��6u   �� 5*   
   -   5        $ 
LBL_glaube��5*      $��GLAUBE��6$   $
��Left=�65   $��25��6P   $��357,279,0,0q�6\   $	��Top=�6q   $	��114��6�   �� 5+   
   $��Merkmale��6   $
��Left=�6#   $��25��6>   $��296,304,0,0q�6J   $	��Top=�6_   $��78��6w   �� 5,   
   -   5        $ LBL_merkmale��5,      $��MERKMALE��6&   $
��Left=�69   $��25��6T   $��301,329,0,0q�6`   $	��Top=�6u   $	��158��6�   �� 5-   
   $
��Left=�6   $��25��6/   $��
10,131,0,0q�6;   
���   �$	��Top=�6^   $��55��6v   �� 5.   
   $��St��6   $
��Left=�6   $��25��68   $��
10,131,0,0q�6D   $	��Top=�6X   $��25��6p   �� 5/   
   -   5        $ LBL_ST��5/      $��0��6    $
��Left=�6,   $��25��6G   $��
35,131,0,0q�6S   $	��Top=�6g   $��30��6   �� 50   
   $
��Left=�6   $��25��6/   $��
69,131,0,0q�6;   
���   �$	��Top=�6^   $��54��6v   �� 51   
   $��Gs��6   $
��Left=�6   $��25��68   $��
69,131,0,0q�6D   $	��Top=�6X   $��24��6p   �� 52   
   -   5        $ LBL_GS��52      $��0��6    $
��Left=�6,   $��25��6G   $��
93,131,0,0q�6S   $	��Top=�6g   $��30��6   �� 53   
   $
��Left=�6   $��25��6/   $��127,131,0,0q�6;   
���   �$	��Top=�6_   $��56��6w   �� 54   
   $��Gw��6   $
��Left=�6   $��25��68   $��127,131,0,0q�6D   $	��Top=�6Y   $��26��6q   �� 55   
   -   5        $ LBL_GW��55      $��0��6    $
��Left=�6,   $��25��6G   $��153,131,0,0q�6S   $	��Top=�6h   $��30��6�   �� 56   
   $
��Left=�6   $��25��6/   $��188,131,0,0q�6;   
���   �$	��Top=�6_   $��56��6w   �� 57   
   $��Ko��6   $
��Left=�6   $��25��68   $��188,131,0,0q�6D   $	��Top=�6Y   $��26��6q   �� 58   
   -   5        $ LBL_KO��58      $��0��6    $
��Left=�6,   $��25��6G   $��214,131,0,0q�6S   $	��Top=�6h   $��30��6�   �� 59   
   $
��Left=�6   $��25��6/   $��
10,160,0,0q�6;   
���   �$	��Top=�6^   $��55��6v   �� 5:   
   $��In��6   $
��Left=�6   $��25��68   $��
10,160,0,0q�6D   $	��Top=�6X   $��25��6p   �� 5;   
   -   5        $ LBL_IN��5;      $��0��6    $
��Left=�6,   $��25��6G   $��
35,160,0,0q�6S   $	��Top=�6g   $��30��6   �� 5<   
   $
��Left=�6   $��25��6/   $��
69,160,0,0q�6;   
���   �$	��Top=�6^   $��54��6v   �� 5=   
   $��Zt��6   $
��Left=�6   $��25��68   $��
69,160,0,0q�6D   $	��Top=�6X   $��24��6p   �� 5>   
   -   5        $ LBL_ZT��5>      $��0��6    $
��Left=�6,   $��25��6G   $��
93,160,0,0q�6S   $	��Top=�6g   $��30��6   �� 5?   
   $
��Left=�6   $��25��6/   $��127,160,0,0q�6;   
���   �$	��Top=�6_   $��56��6w   �� 5@   
   $��Au��6   $
��Left=�6   $��25��68   $��127,160,0,0q�6D   $	��Top=�6Y   $��26��6q   �� 5A   
   -   5        $ LBL_AU��5A      $��0��6    $
��Left=�6,   $��25��6G   $��153,160,0,0q�6S   $	��Top=�6h   $��30��6�   �� 5B   
   $
��Left=�6   $��25��6/   $��188,160,0,0q�6;   
���   �$	��Top=�6_   $��56��6w   �� 5C   
   $��pA��6   $
��Left=�6   $��25��68   $��188,160,0,0q�6D   $	��Top=�6Y   $��26��6q   �� 5D   
   -   5        $ LBL_PA��5D      $��0��6    $
��Left=�6,   $��25��6G   $��214,160,0,0q�6S   $	��Top=�6h   $��30��6�   �� 5E   
   $
��Left=�6   $��25��6/   $��
10,189,0,0q�6;   
���   �$	��Top=�6^   $��55��6v   �� 5F   
   $��Wk��6   $
��Left=�6   $��25��68   $��
10,189,0,0q�6D   $	��Top=�6X   $��25��6p   �� 5G   
   -   5        $ LBL_WK��5G      $��0��6    $
��Left=�6,   $��25��6G   $��
35,189,0,0q�6S   $	��Top=�6g   $��30��6   �� 5H   
   $
��Left=�6   $��25��6/   $��
69,189,0,0q�6;   
���   �$	��Top=�6^   $��54��6v   �� 5I   
   $��B��6   $
��Left=�6   $��25��67   $��
69,189,0,0q�6C   $	��Top=�6W   $��24��6o   �� 5J   
   -   5        $ LBL_BW��5J      $��0��6    $
��Left=�6,   $��25��6G   $��
93,189,0,0q�6S   $	��Top=�6g   $��30��6   �� 5K   
   $��Raufen:��6   $
��Left=�6"   $��24��6=   $��128,190,0,0q�6I   $	��Top=�6^   $��55��6v   �� 5L   
   -   5        $ 
LBL_RAUFEN��5L      $��+0��6$   $
��Left=�61   $��28��6L   $��188,190,0,0q�6X   $	��Top=�6m   $��58��6�   �� 5M   
   $��persöhmlicher Bonus��6   $
��Left=�6.   $��25��6I   $��
10,227,0,0q�6U   $	��Top=�6i   $	��236��6�   $��8(�6�   �� 5N   
   $��Ausdauer��6   $
��Left=�6#   $��25��6>   $��
10,254,0,0q�6J   $	��Top=�6^   $��65��6v   �� 5O   
   -   5        $ LBL_AUSB��5O      $��0��6"   $
��Left=�6.   $��25��6I   $��
93,254,0,0q�6U   $	��Top=�6i   $��35��6�   �� 5P   
   $��Schaden��6   $
��Left=�6"   $��25��6=   $��134,254,0,0q�6I   $	��Top=�6^   $��65��6v   �� 5Q   
   -   5        $ 
LBL_SCHADB��5Q      $��0��6$   $
��Left=�60   $��25��6K   $��217,254,0,0q�6W   $	��Top=�6l   $��35��6�   �� 5R   
   $��Angriff��6   $
��Left=�6"   $��25��6=   $��
10,284,0,0q�6I   $	��Top=�6]   $��65��6u   �� 5S   
   -   5        $ LBL_ANGB��5S      $��0��6"   $
��Left=�6.   $��25��6I   $��
93,284,0,0q�6U   $	��Top=�6i   $��35��6�   �� 5T   
   $��	Resistenz��6   $
��Left=�6$   $��25��6?   $��134,284,0,0q�6K   $	��Top=�6`   $��65��6x   �� 5U   
   -   5        $ 	LBL_RES_K��5U      $��0��6#   $
��Left=�6/   $��25��6J   $��217,284,0,0q�6V   $	��Top=�6k   $��27��6�   �� 5V   
   $��Abwehr��6   $
��Left=�6!   $��25��6<   $��
10,314,0,0q�6H   $	��Top=�6\   $��65��6t   �� 5W   
   -    5        $ LBL_ABWB��5W      $��0��6"   $
��Left=�6.   $��25��6I   $��
93,314,0,0q�6U   $	��Top=�6i   $��35��6�   �� 5X   
   $��Zaubern��6   $
��Left=�6"   $��25��6=   $��134,314,0,0q�6I   $	��Top=�6^   $��65��6v   �� 5Y   
   -!   5        $ LBL_ZAUB��5Y      $��0��6"   $
��Left=�6.   $��25��6I   $��217,314,0,0q�6U   $	��Top=�6j   $��35��6�   �� 5Z   
   -"   5        $ 	LBL_RES_G��5Z      $��0��6#   $
��Left=�6/   $��25��6J   $��249,284,0,0q�6V   $	��Top=�6k   $��27��6�   �� 5[   
   $��LP-Max��6   $
��Left=�6!   $��27��6<   $��
10,385,0,0q�6H   $	��Top=�6\   $��55��6t   �� 5\   
   -#   5        $ LBL_LPM��5\      $��00��6!   $
��Left=�6.   $��27��6I   $��
70,385,0,0q�6U   $	��Top=�6i   $��26��6�   �� 5]   
   $��AP-Max��6   $
��Left=�6!   $��27��6<   $��101,385,0,0q�6H   $	��Top=�6]   $��55��6u   �� 5^   
   -$   5        $ LBL_APM��5^      $��00��6!   $
��Left=�6.   $��27��6I   $��162,385,0,0q�6U   $	��Top=�6j   $��28��6�   �� 5_   
   $��GG��6   $
��Left=�6   $��27��68   $��217,385,0,0q�6D   $	��Top=�6Y   $��29��6q   �� 5`   
   -%   5        $ LBL_GG��5`      $��00��6    $
��Left=�6-   $��27��6H   $��251,385,0,0q�6T   $	��Top=�6i   $��28��6�   �� 5a   
   $��SG��6   $
��Left=�6   $��27��68   $��287,385,0,0q�6D   $	��Top=�6Y   $��29��6q   �� 5b   
   -&   5        $ LBL_SG��5b      $��00��6    $
��Left=�6-   $��27��6H   $��321,385,0,0q�6T   $	��Top=�6i   $��28��6�   �� 5c   
   $
��Left=�6   $��27��6/   $��
10,385,0,0q�6;   
���   �$	��Top=�6^   $��91��6v   �� 5d   
   $
��Left=�6   $��27��6/   $��101,385,0,0q�6;   
���   �$	��Top=�6_   $��89��6w   �� 5e   
   $
��Left=�6   $��27��6/   $��216,385,0,0q�6;   
���   �$	��Top=�6_   $��66��6w   �� 5f   
   $
��Left=�6   $��27��6/   $��287,385,0,0q�6;   
���   �$	��Top=�6_   $��70��6w   �� 5g   
   $��EP��6   $
��Left=�6   $��25��68   $��
10,417,0,0q�6D   $	��Top=�6X   $��55��6p   �� 5h   
   $��ES��6   $
��Left=�6   $��25��68   $��
10,447,0,0q�6D   $	��Top=�6X   $��55��6p   �� 5i   
   -'   5        $ LBL_ES��5i      $��0��6    $
��Left=�6,   $��25��6G   $��
75,447,0,0q�6S   $	��Top=�6g   $��53��6   �� 5j   
   -(   5        $ LBL_EP��5j      $��0��6    $
��Left=�6,   $��25��6G   $��
76,417,0,0q�6S   $	��Top=�6g   $��52��6   �� 5k   
   $
��Geld��6   $
��Left=�6   $��30��6:   $��146,430,0,0q�6F   $	��Top=�6[   $��44��6s   �� 5l   
   -)   5        $ LBL_GELD��5l      $��0��6"   $
��Left=�6.   $��30��6I   $��201,430,0,0q�6U   $	��Top=�6j   $	��156��6�   �� 5m   
   -*   5         ��Name$ SCRVW_Fertigkeiten��5m      $
��Left=�63   $	��390��6N   $��
500,82,0,0q�6[   $	��Top=�6o   $	��273��6�   $��Fertigkeiten��6�   �� 5n   
   -+   5         ��Name$ BTN_Load_Charakter��5n      $��Öffnen��6-   $
��Left=�6>   $��43��6Y   $��
803,54,0,0q�6e   $	��Top=�6y   $	��136��6�   6�   �� 5o   
   -,   5        $ BTN_Save_charakter��5o      $��	Speichern��6-   $
��Left=�6A   $��43��6\   $��
803,97,0,0q�6h   $	��Top=�6|   $	��136��6�   6�   �� 5q   
   --   5        $ 
BTN_reload��5q      $��Aktualisieren��6%   $
��Left=�6=   $��42��6X   $��803,139,0,0q�6d   $	��Top=�6y   $	��136��6�   6�   �� 5r   
   -.   5        $ BTN_make_new��5r      $��neuer Charakter��6'   $
��Left=�6A   $��42��6\   $��803,179,0,0q�6h   $	��Top=�6}   $	��136��6�   6�   �� 5s   
   -/   5        $ BTN_new_skill��5s      $��neue Fertigkeit��6(   $
��Left=�6B   $��44��6]   $��803,221,0,0q�6i   $	��Top=�6~   $	��136��6�   6�   �� 5t   
   -0   5        $ BTN_new_weapon��5t      $��
neue Waffe��6)   $
��Left=�6>   $��42��6Y   $��803,265,0,0q�6e   $	��Top=�6z   $	��136��6�   6�   �� 5u   
   -1   5        $ BTN_new_thing��5u      $��neuer Gegenstand��6(   $
��Left=�6C   $��44��6^   $��803,307,0,0q�6j   $	��Top=�6   $	��136��6�   6�   �� 5v   
   -2   5        $ BTN_change_werte��5v      $��Werte Ändern��6+   $
��Left=�6B   $��44��6]   $��803,351,0,0q�6i   $	��Top=�6~   $	��136��6�   6�   �� 5w   
   -3   5        $ BTN_show_inv��5w      $��Inventar anzeigen��6'   $
��Left=�6C   $��44��6^   $��802,395,0,0q�6j   $	��Top=�6   $	��136��6�   6�   �� 5x   
   -4   5        $ BTN_show_weap��5x      $��Waffen anzeigen��6(   $
��Left=�6B   $��44��6]   $��803,439,0,0q�6i   $	��Top=�6~   $	��136��6�   6�   5y      5{      