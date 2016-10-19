Imports Kavenegar
Imports Kavenegar.Excepctions
Module Module1
 Sub Main()
	VerifyLookup()
 End Sub
 Sub VerifyLookup()
	Try
	 Dim api As New KavenegarApi("")
	 Const receptor = ""
	 Const token = ""
	 Const token2 = ""
	 Const token3 = ""
	 Const template = ""
	 Dim message = api.VerifyLookup(receptor, token, token2, token3, template)
	 Console.WriteLine("Messageid : " & message.Messageid)
	 Console.WriteLine("Message : " & message.Message)
	 Console.WriteLine("Receptor : " & message.Receptor)
	 Console.WriteLine("Sender : " & message.Sender)
	 Console.WriteLine("Date : " & message.Date)
	 Console.ReadKey()
	Catch ex As ApiException
	 Console.WriteLine("Message : " & ex.Message)
	 Console.ReadKey()
	Catch ex As HttpException
	 Console.WriteLine("Message : " & ex.Message)
	 Console.ReadKey()
	End Try
 End Sub
End Module