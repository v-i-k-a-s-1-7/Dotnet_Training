class Competition{

    #region Declaration
    private string  compID{get;}
    private string compName{get;}
    private int comPrizePool{get; set;}
    private string Winner{get; set;}
    private string RunnerUp{get; set;}
    #endregion

    #region Constructor
    public  getDetails(string compID, string compName, int comPrizePool){
        this.compID = compID;
        this.compName = compName;
        this.comPrizePool = comPrizePool;
    }
    #endregion

