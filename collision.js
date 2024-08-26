#pragma strict


	function OnTriggerEnter2D (Col:Collider2D)
	{
		if (Col.CompareTag("george")) {
			Destroy(gameObject);

		}
	}
