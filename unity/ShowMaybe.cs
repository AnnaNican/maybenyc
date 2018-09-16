 public GameObject NowNYC;
    public GameObject MaybeNYC;
    //public bool showMaybe = false;
    private bool isAnimating = false;
    public float animationSpeed = 0.5f;
    private float scale = 0.0f;
    private float last_scale = 0.0f;
    private float direction = 1.0f;
    private bool isShowingMaybe = false;
    private bool isShowingNow = false;


    private void ToggleObjRender(GameObject show, GameObject hide )
    {
        Renderer[] rs = show.GetComponentsInChildren<Renderer>();
        foreach( Renderer r in rs ) {
            r.enabled = true;
        }
        Renderer[] hrs = hide.GetComponentsInChildren<Renderer>();
        foreach (Renderer hr in hrs)
        {
            hr.enabled = false;
        }
    }


    private void Change()
        {
        if (transform.localScale[0] == 1.0f)
        {
            transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
        }
        else
        {
            transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }
    }

    void Start()
    {
    }

    void Update() {
        return;
    }

    void OnSelect()
    {
        Change();
    }

    void OnShowNow() {
        ToggleObjRender(NowNYC, MaybeNYC);
    }

    void OnShowMaybe() {
        ToggleObjRender(MaybeNYC, NowNYC);
    }
}