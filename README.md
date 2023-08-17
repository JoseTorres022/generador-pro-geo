# Geometric Progression Ganeration
Este pequeño programa en Visual Basic, Generador de Progresión Geométrica (_Geometric Progression Generator_), es un programa que genera una sucesión de números y los muestra en un control (_ListBox_).
La progresión geométrica es una sucesión en la que cada término se obtiene multiplicando al anterior por una cantidad fija **"r"**, llamada razón (_Common Ratio_).
La razón **"r"** o razón (_Common Ratio_), puede ser un negativo, un entero, una fracción o cualquier otro número pero nunca cero.

La formúla a encontrar en el número de terminos de la progresión geométrica es **ar^n-1**, donde **"a"** es el primer número (_First Number_) y donde **"r"** es la razon (_Common Ratio_).

En Visual Basic, se uso la estructura de datos **Do...Loop Until** para generar la serie de números. Donde se usaran controles de _labels_, _Textboxes_, _Buttons_ y _ListBox_. 
Para mostrar los datos calculados, se necesita del control _ListBox_, usando el metódo **Items**. La sintaxis es **LBOX1_VistaGenerada.Items.Add (n)**, donde **n** puede ser cualquier variable/número.

Vista del programa:
https://github.com/JoseTorres022/generador-pro-geo/blob/master/GENERADTOR-PRO-GEO.png

En este programa se usan los siguientes controles:
Tres etiquetas (_labels_)
1. Etiqueta: Primer número (LB1_PrimerNumero)
2. Etiqueta: Radio Común o Razón (LB2_RadioComun)
3. Etiqueta: Número de terminos (LB3_NoTerminos)

Tres cajas de textos (_TextBox_)
1. Caja de texto: Primer número (TB1_PrimerNumero)
2. Caja de texto: Radio Común (TB2_RadioComun)
3. Caja de texto: Número de terminos (TB3_NoTerminos)

Dos botónes (_Button_)
1. Botón: Cacular datos (BT1_CalcDatos)
2. Botón: Salir (BT2_CerrarApp)

Una caja de lista (_ListBox_)
Caja de lista: Mostrara la sucesión geométrica (LBOX1_VistaGenerada)
