// SPDX-License-Identifier: GPL-3.0

pragma solidity >=0.7.0 <0.9.0;
 
/**
 * @title mapData
 * @dev Store & retrieve data from a map object
 */
contract mapDataStorage {


    struct EntityData {
    uint8 x;
    uint8 y;
    uint8 entityType;
    }

    bytes mapData;
    
    string constant testFloorsWalls = "2222222222222222222221112112222222222222222222222211111111112222222111122222222221112211211122222211111122222222222111111111222222111211122222222221111112112222211112111122221122222222112122222112121111112111122222211111222221111111111121111112221122112222111121111111211111122211111112221111111111111111111221111111122211121111111111111112221122121112211111221111111111122222111211122221121111112211122222211111212222222211111121111222221211122222222222222111211112222111112222222222221111111111122221112122222222222211111111111112221121112222222222111111111111122211112122222222222112222222111222211112222222222221111211221112222111222222222222211111111111122222122222222222221112111111111222222222222222222111112111111112222222222222222211121121111111222222222122222222111112112112111222222211122222221122121111111122222222112122222211112112221111222222221111122222211111112222112221122221111222221122111122222122211122211122222211111221122222222111111112222222211111111222222222111122222222222211121122222222222222222222";

    EntityData[32] public entityData;

    function mapStringToBytes(string memory mapAsString) public
    {
        mapData = new bytes(128);
        require(mapData.length == 128, "Incorrect map size"); // 32x32 maps are always 1024 bits aka 128 bytes
        mapData = bytes(mapAsString);
    }
    
    function testDataToBytes(string memory str) public 
    {
        //mapData = (bytes)str;
    }
     
    function returnTestString() public pure returns (string memory)
    {
        return testFloorsWalls;
    }
    
    
    function getMapAsString() public view returns(string memory)
    {
        string memory s  = bytesArrayToString(mapData);
        return s;
    }
    
    function stringToBytesArray(string memory str) public pure returns (bytes memory){
        return bytes(str);
    } 
    
    function bytesArrayToString(bytes memory _bytes) public pure returns (string memory) {
        return string(_bytes);
    }
}
