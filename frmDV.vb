'--------------------------------------------------------------------------------
' Código gerado pela conversão de VB6 para VB.NET
'--------------------------------------------------------------------------------

'A conversão foi feita por um software de EHASIS - Edison Henrique Andreassy <ehasis@hotmail.com>
'Veja também em:
'http://www.ehasis.com/arquivos/
'Tópico no VBMania:
'http://www.vbmania.com.br/index.php?modulo=forum&metodo=abrir&id=444407&pagina=1
'

Option Strict Off ' Código convertido do VB6 possui Option Strict Off por padrão

Friend Class frmDV

    Private Sub cmdCalcularRG_Click() Handles cmdCalcularRG.Click
        lblDVRG.Caption = Trim(mdlCalculo.CalculoDV11(ByVal6(txtRG.Text)))
    End Sub

    Private Sub cmdCalcularRIC_Click() Handles cmdCalcularRIC.Click
        lblDVRIC.Caption = Trim(mdlCalculo.Mod_dig11(txtRIC.Text))
    End Sub

End Class
