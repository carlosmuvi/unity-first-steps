using UnityEngine;
using System.Collections;

public class CharacterSpawn : MonoBehaviour {

	public Transform spawnPosition;
	public GameObject spawnCharacter;
	public int spawnCount;
	public float spawnCooldown = 1;

	private float timeUntilSpawn = 0;

	public void Update()
	{
		timeUntilSpawn -= Time.deltaTime;

		if(timeUntilSpawn <= 0 && spawnCount > 0)
		{
			SpawnEnemy();
			spawnCount--;
			timeUntilSpawn = spawnCooldown;
		}
	}

	private void SpawnEnemy()
	{
		GameObject gameObject = Instantiate(spawnCharacter, spawnPosition.position, Quaternion.identity) as GameObject;
	}

}
