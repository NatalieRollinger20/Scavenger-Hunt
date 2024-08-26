#pragma strict

	var level:String;

	function OnTriggerEnter2D(Col:Collider2D){
		if(Col.CompareTag("george")){
			Application.LoadLevel(level);
	}
}
