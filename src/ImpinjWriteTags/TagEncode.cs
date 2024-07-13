namespace ImpinjWriteTags
{
    /// <summary>
    /// Representa os dados para codificação de um tag
    /// </summary>
    public class TagEncode
    {
        public string CurrentEpc { get; private set; }  // EPC atual, apenas como referência, não impacta no processo de codificação
        public string Tid { get; private set; }         // Identificador exclusivo
        public string NewEpc { get; private set; }      // Valor EPC que será gravado
        public bool Encoded { get; set; }               // Resultado do processo

        public TagEncode(string currentEpc, string tid, string newEpc)
        {
            CurrentEpc = currentEpc;
            Tid = tid;
            NewEpc = newEpc;
        }
    }
}