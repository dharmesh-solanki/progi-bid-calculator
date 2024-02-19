namespace ProgiBidCalculator.API.DTO.BaseModel
{
    /// <summary>
    /// Response model
    /// </summary>
    public class BaseResponse
    {
        /// <summary>
        /// Shows the error message if request failed to execute
        /// </summary>
        public string Message { get; set; } = string.Empty;
    }
}
