﻿using System.Text.Json.Serialization;

namespace BrasilAPI.Models
{

    public class CnaesSecundarioModel
    {
        [JsonPropertyName("codigo")]
        public int Codigo { get; set; }

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }
    }

    public class CNPJModel
    {

        [JsonPropertyName("uf")]
        public string Uf { get; set; }

        [JsonPropertyName("cep")]
        public string Cep { get; set; }

        [JsonPropertyName("qsa")]
        public List<object> Qsa { get; set; }

        [JsonPropertyName("cnpj")]
        public string Cnpj { get; set; }

        [JsonPropertyName("pais")]
        public object Pais { get; set; }

        [JsonPropertyName("email")]
        public object Email { get; set; }

        [JsonPropertyName("porte")]
        public string Porte { get; set; }

        [JsonPropertyName("bairro")]
        public string Bairro { get; set; }

        [JsonPropertyName("numero")]
        public string Numero { get; set; }

        [JsonPropertyName("ddd_fax")]
        public string DddFax { get; set; }

        [JsonPropertyName("municipio")]
        public string Municipio { get; set; }

        [JsonPropertyName("logradouro")]
        public string Logradouro { get; set; }

        [JsonPropertyName("cnae_fiscal")]
        public int CnaeFiscal { get; set; }

        [JsonPropertyName("codigo_pais")]
        public object CodigoPais { get; set; }

        [JsonPropertyName("complemento")]
        public string Complemento { get; set; }

        [JsonPropertyName("codigo_porte")]
        public int CodigoPorte { get; set; }

        [JsonPropertyName("razao_social")]
        public string RazaoSocial { get; set; }

        [JsonPropertyName("nome_fantasia")]
        public string NomeFantasia { get; set; }

        [JsonPropertyName("capital_social")]
        public int CapitalSocial { get; set; }

        [JsonPropertyName("ddd_telefone_1")]
        public string DddTelefone1 { get; set; }

        [JsonPropertyName("ddd_telefone_2")]
        public string DddTelefone2 { get; set; }

        [JsonPropertyName("opcao_pelo_mei")]
        public bool OpcaoPeloMei { get; set; }

        [JsonPropertyName("descricao_porte")]
        public string DescricaoPorte { get; set; }

        [JsonPropertyName("codigo_municipio")]
        public int CodigoMunicipio { get; set; }

        [JsonPropertyName("cnaes_secundarios")]
        public List<CnaesSecundarioModel> CnaesSecundarios { get; set; }

        [JsonPropertyName("natureza_juridica")]
        public string NaturezaJuridica { get; set; }

        [JsonPropertyName("situacao_especial")]
        public string SituacaoEspecial { get; set; }

        [JsonPropertyName("opcao_pelo_simples")]
        public bool OpcaoPeloSimples { get; set; }

        [JsonPropertyName("situacao_cadastral")]
        public int SituacaoCadastral { get; set; }

        [JsonPropertyName("data_opcao_pelo_mei")]
        public string DataOpcaoPeloMei { get; set; }

        [JsonPropertyName("data_exclusao_do_mei")]
        public string DataExclusaoDoMei { get; set; }

        [JsonPropertyName("cnae_fiscal_descricao")]
        public string CnaeFiscalDescricao { get; set; }

        [JsonPropertyName("codigo_municipio_ibge")]
        public int CodigoMunicipioIbge { get; set; }

        [JsonPropertyName("data_inicio_atividade")]
        public string DataInicioAtividade { get; set; }

        [JsonPropertyName("data_situacao_especial")]
        public object DataSituacaoEspecial { get; set; }

        [JsonPropertyName("data_opcao_pelo_simples")]
        public string DataOpcaoPeloSimples { get; set; }

        [JsonPropertyName("data_situacao_cadastral")]
        public string DataSituacaoCadastral { get; set; }

        [JsonPropertyName("nome_cidade_no_exterior")]
        public string NomeCidadeNoExterior { get; set; }

        [JsonPropertyName("codigo_natureza_juridica")]
        public int CodigoNaturezaJuridica { get; set; }

        [JsonPropertyName("data_exclusao_do_simples")]
        public object DataExclusaoDoSimples { get; set; }

        [JsonPropertyName("motivo_situacao_cadastral")]
        public int MotivoSituacaoCadastral { get; set; }

        [JsonPropertyName("ente_federativo_responsavel")]
        public string EnteFederativoResponsavel { get; set; }

        [JsonPropertyName("identificador_matriz_filial")]
        public int IdentificadorMatrizFilial { get; set; }

        [JsonPropertyName("qualificacao_do_responsavel")]
        public int QualificacaoDoResponsavel { get; set; }

        [JsonPropertyName("descricao_situacao_cadastral")]
        public string DescricaoSituacaoCadastral { get; set; }

        [JsonPropertyName("descricao_tipo_de_logradouro")]
        public string DescricaoTipoDeLogradouro { get; set; }

        [JsonPropertyName("descricao_motivo_situacao_cadastral")]
        public string DescricaoMotivoSituacaoCadastral { get; set; }

        [JsonPropertyName("descricao_identificador_matriz_filial")]
        public string DescricaoIdentificadorMatrizFilial { get; set; }
    
    }

}
