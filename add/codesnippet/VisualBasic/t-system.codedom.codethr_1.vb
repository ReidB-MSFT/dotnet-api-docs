         ' This CodeThrowExceptionStatement throws a new System.Exception.
         ' The codeExpression parameter indicates the exception to throw.
         ' You must use an object create expression to new an exception here.
         Dim throwException As New CodeThrowExceptionStatement( _
        New CodeObjectCreateExpression( _
            New CodeTypeReference(GetType(System.Exception)), _
            New CodeExpression() {}))

         ' A Visual Basic code generator produces the following source code for the preceeding example code:

         ' Throw New System.Exception