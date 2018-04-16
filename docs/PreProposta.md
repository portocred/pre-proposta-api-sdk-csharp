# IO.Swagger.Model.PreProposta
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Operador** | **string** | Identificação do operador. | [optional] 
**CodigoProduto** | **string** | Código do produto. Pelo Produto se descobre também a família de produto. | [optional] 
**ValorCompra** | **double?** | Valor da compra sem entrada (neste caso valor da prestação &#x3D; zero). | [optional] 
**ValorPrestacao** | **double?** | Valor da PMT a (neste caso valor da compra &#x3D; zero/ valor da entrada &#x3D; 0). | [optional] 
**PrazoPagamento** | **string** | Prazo de pagamento. | [optional] 
**TipoSeguro** | **TipoSeguro** |  | [optional] 
**DataVencimentoPrimeiraParcela** | **DateTime?** | Data de vencimento da 1ª parcela. Verificar se está coerente com a Carência mínima e máxima combinada com a financeira (dd-mm-aaaa). | [optional] 
**Candidato** | [**Candidato**](Candidato.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

