# IO.Swagger.Api.PrePropostaApi

All URIs are relative to *https://dev-api.portocred.com.br/gestao-proposta/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PrePropostasPost**](PrePropostaApi.md#prepropostaspost) | **POST** /pre-propostas | 


<a name="prepropostaspost"></a>
# **PrePropostasPost**
> InclusaoPrePropostaResponse PrePropostasPost (string clientId, string accessToken, byte[] xAuthorization, string codigoLoja, string codigoLojista, PreProposta preProposta)



Esta API tem o objetivo de incluir uma análise de dados sobre uma pré-proposta de crédito. Caso o cliente já possua uma proposta em andamento, ou qualquer outra inconsistência na inclusão, o sistema irá retornar um código de erro informando o motivo. Caso seja aprovada, uma proposta será incluída.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrePropostasPostExample
    {
        public void main()
        {
            var apiInstance = new PrePropostaApi();
            var clientId = clientId_example;  // string | Client ID disponibilizado na criação da App.
            var accessToken = accessToken_example;  // string | Access Token com permissões de acesso.
            var xAuthorization = B;  // byte[] | base64 do codigoParceiro:codigoUsuario:senha.
            var codigoLoja = codigoLoja_example;  // string | Código da loja (Filial). (fixo informada pela financeira).
            var codigoLojista = codigoLojista_example;  // string | Código do lojista (Rede de loja). (fixo informada pela financeira).
            var preProposta = new PreProposta(); // PreProposta | Pré-Proposta a ser analisada, cujo resultado, quando aprovada é uma proposta.

            try
            {
                InclusaoPrePropostaResponse result = apiInstance.PrePropostasPost(clientId, accessToken, xAuthorization, codigoLoja, codigoLojista, preProposta);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrePropostaApi.PrePropostasPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Client ID disponibilizado na criação da App. | 
 **accessToken** | **string**| Access Token com permissões de acesso. | 
 **xAuthorization** | **byte[]**| base64 do codigoParceiro:codigoUsuario:senha. | 
 **codigoLoja** | **string**| Código da loja (Filial). (fixo informada pela financeira). | 
 **codigoLojista** | **string**| Código do lojista (Rede de loja). (fixo informada pela financeira). | 
 **preProposta** | [**PreProposta**](PreProposta.md)| Pré-Proposta a ser analisada, cujo resultado, quando aprovada é uma proposta. | 

### Return type

[**InclusaoPrePropostaResponse**](InclusaoPrePropostaResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

